using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemSizeUp : ButtonBase
{

    List<GameObject> roads = new List<GameObject>();

    private int lastRoadIndex;

    public override void OnClickButton()
    {
        UnlockNewRoad();
    }

    private void UnlockNewRoad()
    {
        roads[lastRoadIndex + 1].SetActive(true);
        lastRoadIndex++;
    }

}
