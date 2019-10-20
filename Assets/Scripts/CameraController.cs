using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CameraController : MonoBehaviour
{
    private float xAxis, yAxis;
    private Vector3 initPosition;
    private Quaternion initRotation;

    private void Start()
    {
        initPosition = Camera.main.transform.position;
        initRotation = Camera.main.transform.localRotation;
    }

    void Update()
    {
        yAxis = CrossPlatformInputManager.GetAxis("Vertical");
        this.transform.position += yAxis * this.transform.forward;
    }

    public void CameraReset()
    {
        Camera.main.transform.position = initPosition;
        Camera.main.transform.localRotation = initRotation;
    }


}