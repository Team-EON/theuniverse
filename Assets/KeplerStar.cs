using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeplerStar : MonoBehaviour
{
    public int numberOfPlanets;
    public GameObject planetPrefab;

    void Start()
    {
        KPlanet[] planets = getPlanets();
        foreach(KPlanet planet in planets)
        {
            Debug.Log("Instantiationg");
            GameObject gobj = Instantiate(planetPrefab, new Vector3(0, 0, planet.distance), Quaternion.identity);
            gobj.transform.parent = gameObject.transform;
            KeplerPlanet k = gobj.GetComponent<KeplerPlanet>();
            k.UpdateKPlanet(planet);
        }
    }
    
    KPlanet[] getPlanets()
    {
        PlanetReader reader = GetComponent<PlanetReader>();
        KPlanet[] planets = new KPlanet[numberOfPlanets];
        planets[0] = new KPlanet(15, 2, 3, 7, 1f);
        return planets;
    }
}
