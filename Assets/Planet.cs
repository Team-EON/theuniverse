using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : UniverseEntity
{
    private Rigidbody rb;
    public Vector3 initialForce;
    public float distanceFromStar = 7;
    private Rigidbody anotherPlanet;
    private float mass1, mass2;

    private void Start()
    {
        this.transform.position = new Vector3(0, 0, distanceFromStar);
        anotherPlanet = GameObject.FindGameObjectWithTag("Sun").GetComponent<Rigidbody>();
        this.rb = GetComponent<Rigidbody>();
        mass1 = this.rb.mass;
        mass2 = this.anotherPlanet.mass;
        rb.AddForce(initialForce);
    }

    void FixedUpdate()
    {
        Vector3 distance = anotherPlanet.transform.position - rb.transform.position;
        float gForce = (GravitationalConstant * mass1 * mass2) / Mathf.Pow(distance.magnitude, 2);
        rb.AddForce(distance.normalized * gForce);

        Debug.Log("Distance: " + distance.magnitude + ", Force: " + gForce);
    }
}
