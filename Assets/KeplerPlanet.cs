using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeplerPlanet : MonoBehaviour
{
    private float passedTime;
    public float distance = 20f;
    public float speed = 1.5f; // orbital period
    private float eccentricity = 1f;
    public float radius = 1f;
    public float inclination = 0f;
    public Texture2D customTexture;

    private void Start()
    {
    }

    private void Update()
    {
        transform.position = new Vector3(
            distance * Mathf.Cos((passedTime += Time.deltaTime) * speed) * eccentricity, 
            0, 
            distance * Mathf.Sin((passedTime += Time.deltaTime) * speed));
    }

    public void UpdateKPlanet(KPlanet planet)
    {
        distance = planet.distance;
        radius = planet.radius;
        inclination = planet.inclination;
        speed = planet.speed;
        eccentricity = planet.eccentricity;
        transform.localScale *= planet.radius;
    }
}
