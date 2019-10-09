using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseEntity : MonoBehaviour
{
    [System.NonSerialized]
    public float GravitationalConstant = 40f;
    public float radius = 1f;
    // Ratio of initForce and distance. [Remove it after deriving initForce formula.]
    public static float ifDisRate = 36.5857f;
    protected void Start()
    {
        this.transform.localScale = new Vector3(radius, radius, radius);
    }
}
