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
    [SerializeField]
    public float rotationSpeed = 10f;

    protected void Start()
    {
        Time.timeScale = 2f;
        this.transform.localScale = new Vector3(radius, radius, radius);
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, -rotationSpeed);
    }
}
