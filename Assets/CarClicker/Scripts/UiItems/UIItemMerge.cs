using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemMerge : ButtonBase
{
    
    private bool Merge()
    {

        Dictionary<int, List<CarStateManager>> currentRunners = EventManager.E_CarsManager.Invoke().currentCars;

        for (int level = 0; level < 3; level++)
        {

            if (currentRunners[level].Count >= 3)
            {

                for (int j = 3 - 1; j >= 0; j--)
                {

                    currentRunners[level][j].gameObject.SetActive(false);
                    currentRunners[level].Remove(currentRunners[level][j]);

                }

                EventManager.E_CarsManager.Invoke().currentCars = currentRunners;
                EventManager.E_ObjectPool?.Invoke().GetPooledObject(level + 1);

                return true;

            }

        }

        return false;

    }

    public bool CharNumControl(Dictionary<int, List<CarStateManager>> runners)
    {

        for (int i = 0; i < 3; i++)
        {
            if (runners[i].Count >= 3)
            {

                main_Button.SetActive(true);

                return true;
            }
        }

        return false;

    }

    public override void OnClickButton()
    {
        if (CheckAmount() && Merge())
        {
            UpdateCost();
            UpdateText();
        }
    }


    //public void MergeBTNControl()
    //{
    //    if (CharNumControl(EventManager.E_CarsManager.Invoke().currentCars) && EventManager.E_AmountManager.Invoke().AmountCheck(upgradeCost))
    //    {

    //        MergeBTN_base.SetActive(true);
    //        MergeBTN.SetActive(true);
    //        MergeBTN_passive.SetActive(false);
    //    }
    //    else if (CharNumControl(EventManager.E_CarsManager.Invoke().currentCars) && !EventManager.E_AmountManager.Invoke().AmountCheck(upgradeCost))
    //    {
    //        MergeBTN_base.SetActive(true);
    //        MergeBTN.SetActive(false);
    //        MergeBTN_passive.SetActive(true);
    //    }
    //    else
    //    {
    //        MergeBTN_base.SetActive(false);
    //    }
    //}
}
