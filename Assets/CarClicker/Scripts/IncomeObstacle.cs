using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeObstacle : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CarStateManager car))
        {
        }
    }
}
