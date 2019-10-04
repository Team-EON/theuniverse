using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : UniverseEntity
{
    private Rigidbody rb;
    public Vector3 initialForce;
    public Rigidbody anotherPlanet;
    private float GravitationalConstant = 10f;
    private float mass1, mass2;

    private void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        mass1 = this.rb.mass;
        mass2 = this.anotherPlanet.mass;
        rb.AddForce(initialForce);
    }

    void FixedUpdate()
    {
        Vector3 direction = anotherPlanet.transform.position - rb.transform.position;
        float gForce = (GravitationalConstant * mass1 * mass2) / Mathf.Pow(direction.magnitude, 2);
        initialForce = initialForce + (direction.normalized * gForce);
        rb.AddForce(direction.normalized * gForce);
    }
}
