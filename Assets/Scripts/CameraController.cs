using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float positionChangeSensitivity = 0.5f;
    private float xAxis, yAxis;
    
    void Update()
    {
        // Change position
        xAxis = CrossPlatformInputManager.GetAxis("Horizontal");
        yAxis = CrossPlatformInputManager.GetAxis("Vertical");
        Debug.Log("forward: " + this.transform.forward + " position: " + this.transform.position);
        this.transform.position += yAxis * this.transform.forward;
    }
}
