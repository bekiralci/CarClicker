using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CarStateManager : MonoBehaviour
{

    public int level;
    public float _income;

    public Transform car;
    public Transform carBody;
    public List<Transform> wheels;

    public Vector3 driftRotation;
    public Vector3 wheelDriftRotation;

    public List<TrailRenderer> trails;

    private void OnDisable()
    {
        //EventManager.E_ObjectPool?.Invoke().pools[level - 1].pooledObjects.Add(this);
    }

    public void DriftState()
    {
        car.DOLocalRotate(driftRotation, .4f);
        carBody.DOLocalRotate(new Vector3(2, 0, 3), .3f);
        wheels[0].DOLocalRotate(wheelDriftRotation, .3f);
        wheels[1].DOLocalRotate(wheelDriftRotation, .3f);
    }

    public void NormalState()
    {
        car.DOLocalRotate(Vector3.zero, 1f);
        carBody.DOLocalRotate(new Vector3(-5, 0, 0), 1f);
        wheels[0].DOLocalRotate(Vector3.zero, .8f);
        wheels[1].DOLocalRotate(Vector3.zero, .6f);
    }

    public void Trail(bool state)
    {
        for (int i = 0; i < trails.Count; i++)
        {
            trails[i].enabled = state;
        }
    }

}
