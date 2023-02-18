using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountObstacle : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Car car))
        {
            EventManager.E_AmountManager.Invoke().Add(car._income);//todo
        }
    }
}
