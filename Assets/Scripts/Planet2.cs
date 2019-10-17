using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet2 : UniverseEntity
{
    private Rigidbody rb;
    private Vector3 initialForce;
    private Rigidbody anotherPlanet;
    public float distanceFromStar = 7;
    private float massMultiple;
    private float mass1, mass2;

    private void Start()
    {
        // distanceFromStar *= 1000; // Converting to our unit [1000km = 1ou]
        base.Start();

        // We are just plotting in z axis now for test purpose. Do the following to input exact position from the star.
        // 1. change data type of distanceFromStar to Vector3
        // 2. "new Vector3(0, 0, distanceFromStar)" > "distanceFromStar"
        // Now you will be able to input the vector position of the planet.
        // Note: now the actual distance from star is the distanceFromStar.magnitude
        this.transform.position = new Vector3(0, 0, distanceFromStar);

        // TODO Get a formular to get such initial factor that the elliptical path's eccentricity get close to 1.
        // initialForce depends on mass and distance from star
        initialForce = new Vector3(ifDisRate * Mathf.Pow(distanceFromStar, 0.5f), 0, 0);
        this.rb = GetComponent<Rigidbody>();
        massMultiple = GravitationalConstant * this.rb.mass * this.anotherPlanet.mass;
        rb.AddForce(initialForce);
    }

    void FixedUpdate()
    {
        Vector3 distance = anotherPlanet.transform.position - rb.transform.position;
        float gForce = massMultiple / Mathf.Pow(distance.magnitude, 2);
        Debug.Log("Direction: " + distance.magnitude + ", " + gForce);
        rb.AddForce(distance.normalized * gForce);
    }
}
