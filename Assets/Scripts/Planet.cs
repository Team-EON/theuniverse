﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : UniverseEntity
{
    private Rigidbody rb;
    [SerializeField]
    private float force;
    [SerializeField]
    private float degree = 1f;
    private Vector3 initialForce;
    public float distanceFromStar = 7;
    private Rigidbody anotherPlanet;
    private float massMultiple;

    private void Start()
    {
        base.Start();
        this.transform.position = new Vector3(0, 0, distanceFromStar);
        anotherPlanet = GameObject.FindGameObjectWithTag("Sun").GetComponent<Rigidbody>();
        this.rb = GetComponent<Rigidbody>();
        massMultiple = (GravitationalConstant * this.rb.mass * this.anotherPlanet.mass);
        initialForce = new Vector3(force, 0, 0);
        rb.AddForce(initialForce);

        transform.Rotate(Vector3.left, degree);
    }

    void FixedUpdate()
    {
        Vector3 distance = anotherPlanet.transform.position - rb.transform.position;
        massMultiple = (GravitationalConstant * this.rb.mass * this.anotherPlanet.mass);
        float gForce = massMultiple / Mathf.Pow(distance.magnitude, 2);
        rb.AddForce(distance.normalized * gForce);

    }
}