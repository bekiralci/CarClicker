using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsManager : MonoBehaviour
{
    public Dictionary<int, List<CarStateManager>> currentCars = new();

    [SerializeField] private List<CarStateManager> cars_1;
    [SerializeField] private List<CarStateManager> cars_2;
    [SerializeField] private List<CarStateManager> cars_3;
    [SerializeField] private List<CarStateManager> cars_4;

    private void Awake()
    {

        currentCars.Add(0, cars_1);
        currentCars.Add(1, cars_2);
        currentCars.Add(2, cars_3);
        currentCars.Add(3, cars_4);

    }

    #region EventManager

    private void OnEnable()
    {
        EventManager.E_CarsManager += GetThis;
    }

    private void OnDisable()
    {
        EventManager.E_CarsManager -= GetThis;
    }

    #endregion

    private CarsManager GetThis()
    {
        return this;
    }

    public void AddRunner(CarStateManager car)
    {

        currentCars[car.level - 1].Add(car);

    }

}
