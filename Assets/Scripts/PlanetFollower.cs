using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class PlanetFollower : LookatTarget
{
    public PlanetSelectTap planetSelector;
    public void SetPlanet()
    {
        if (planetSelector.GetLastTouched() != null)
        {
            GameObject gObj = planetSelector.GetLastTouched().gameObject;
            SetTarget(gObj.transform);
        }
    }
}
