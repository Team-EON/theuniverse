using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PlanetSelectTap : MonoBehaviour
{
    private Collider lastTouched;
    private void Update()
    {
        if (lastTouched != null)
        {
            Renderer renderer = lastTouched.gameObject.GetComponent<Renderer>();
            renderer.material.color = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(Time.time, 1));
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()) return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, 500f))
            {
                if (lastTouched != null)
                {
                    Renderer renderer = lastTouched.gameObject.GetComponent<Renderer>();
                    renderer.material.color = Color.white;
                }

                lastTouched = hitInfo.collider;
            }
        }
    }

    public Collider GetLastTouched()
        {
            return lastTouched;
        }
}
