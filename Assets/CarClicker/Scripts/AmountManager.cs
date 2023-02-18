using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountManager : MonoBehaviour
{

    public float _totalAmount;

    public void Add(float value)
    {
        _totalAmount += value;
    }

    public void Remove(float value)
    {
        _totalAmount -= value;
    }

    AmountManager GetAmountManager()
    {
        return this;
    }

    #region Enable/Disable/Event

    private void OnEnable()
    {
        EventManager.E_AmountManager += GetAmountManager;
    }

    private void OnDisable()
    {
        EventManager.E_AmountManager -= GetAmountManager;
    }

    #endregion

}
