using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn_Ring : MonoBehaviour
{
    public GameObject planet;
    void Start()
    {
        transform.localScale = new Vector3(850f,850f,10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = planet.transform.position;
    }
}
