using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_slider : MonoBehaviour
{
    public float radius = 250f;
    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(radius, radius, radius);
    }

    public void AdjustRadius(float radiusx)
    {
        radius = radiusx;
    }
}
