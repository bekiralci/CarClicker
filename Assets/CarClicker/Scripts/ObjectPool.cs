using DG.Tweening.Core.Easing;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    [Serializable]
    public struct Pool
    {
        public List<CarStateManager> pooledObjects;
        public CarStateManager objectPrefab;
        public int poolSize;
    }

    public Pool[] pools;

    private void Start()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObjects = new List<CarStateManager>();
            for (int i = 0; i < pools[j].poolSize; i++)
            {
                CarStateManager obj = Instantiate(pools[j].objectPrefab);
                obj.gameObject.SetActive(false);
                pools[j].pooledObjects.Add(obj);
            }
        }
    }

    #region Event
    private void OnEnable()
    {
        EventManager.E_ObjectPool += GetThis;
    }
    private void OnDisable()
    {
        EventManager.E_ObjectPool -= GetThis;
    }
    private ObjectPool GetThis()
    {
        return this;
    }

    #endregion

    public CarStateManager GetPooledObject(int charLevel)
    {
        if (pools[charLevel].pooledObjects.Count == 0)
        {
            return null;
        }

        CarStateManager obj = pools[charLevel].pooledObjects[0];

        pools[charLevel].pooledObjects.Remove(obj);
        obj.gameObject.SetActive(true);

        EventManager.E_CarsManager.Invoke().AddRunner(obj);

        return obj;
    }
}
