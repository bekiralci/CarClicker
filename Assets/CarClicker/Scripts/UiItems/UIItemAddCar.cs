using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemAddCar : ButtonBase
{
    private void AddCar()
    {
        if (CheckAmount())
        {
            CarStateManager obj = EventManager.E_ObjectPool?.Invoke().GetPooledObject(0);
            UpdateCost();
            UpdateText();
        }
    }
    public override void OnClickButton()
    {
        AddCar();
    }

}
