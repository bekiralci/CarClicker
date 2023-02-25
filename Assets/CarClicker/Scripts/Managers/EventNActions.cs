using System;

public class EventManager
{
    public static Func<AmountManager> E_AmountManager;
    public static Func<UIItemIncome> E_UIItemIncome;
    public static Func<CarsManager> E_CarsManager;
    public static Func<ObjectPool> E_ObjectPool;
    public static Func<ButtonManager> E_ButtonManager;
}