using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseEntity : MonoBehaviour
{

    public float diameter = 1f;

    private void Start()
    {
        this.transform.localScale *= diameter;
    }
}
