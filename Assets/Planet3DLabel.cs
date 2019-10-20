using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet3DLabel : MonoBehaviour
{
    private void Update()
    {
        this.transform.LookAt(Camera.main.transform);
    }
}
