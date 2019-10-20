using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseEntity : MonoBehaviour
{
    [System.NonSerialized]
    public float GravitationalConstant = 660f;
    public float radius = 1f;
    // Ratio of initForce and distance. [Remove it after deriving initForce formula.]
    public static float ifDisRate = 36.5857f;
    public string codex;
    public float rotationSpeed = 5f; // rotationSpeed
    public float equatorialInclination = 0f;

    protected void Start()
    {
        Time.timeScale = 3f;
        this.transform.localScale = new Vector3(radius, radius, radius);
        transform.Rotate(Vector3.forward, equatorialInclination);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, -rotationSpeed);
    }
}
