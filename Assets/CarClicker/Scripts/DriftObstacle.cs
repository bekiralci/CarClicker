using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriftObstacle : MonoBehaviour
{

    public bool driftMode;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CarStateManager car))
        {
            if (driftMode)
            {
                car.DriftState();
            }
            else if (!driftMode)
            {
                car.NormalState();
            }
        }
    }
}
