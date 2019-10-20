using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PlanetSelectTap : MonoBehaviour
{
    public Text codexHolder;
    public Collider lastTouched;

    private void Start()
    {
        UniverseEntity planet = lastTouched.gameObject.GetComponent<UniverseEntity>();
        codexHolder.text = planet.codex;
    }

    private void Update()
    {
        if (lastTouched != null)
        {
            Renderer renderer = lastTouched.gameObject.GetComponent<Renderer>();
            renderer.material.color = Color.Lerp(Color.white, new Color(0.3f,0.3f,0.3f,0.5f), Mathf.PingPong(Time.time * 1.3f, 1));
        }


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button pressed.");
            if (EventSystem.current.IsPointerOverGameObject()) return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, 500f))
            {
                if (lastTouched != null)
                {
                    Renderer renderer = lastTouched.gameObject.GetComponent<Renderer>();
                    renderer.material.color = Color.white;
                    UniverseEntity planet = lastTouched.gameObject.GetComponent<UniverseEntity>();
                    codexHolder.text = planet.codex;
                }

                lastTouched = hitInfo.collider;
            } else
            {
                Vector3 rawPosition = Camera.main.WorldToScreenPoint(Input.mousePosition);
                float xPos = rawPosition.x;
                float yPos = rawPosition.y;
                Debug.Log("Touch: " + xPos + ", " + yPos);
            }
        }
    }

    public Collider GetLastTouched()
        {
            return lastTouched;
        }

    public void OnRadiusChangeListener(float value)
    {
        lastTouched.gameObject.transform.localScale = new Vector3(value, value, value);
    }

    public void OnMassChangeListener(float value)
    {
        // FIXME mass for one planet is not constant anymore
        lastTouched.attachedRigidbody.mass = value * 100f;
    }

    public void OnRSpeedListener(float value)
    {
        Planet planet = lastTouched.gameObject.GetComponent<Planet>();
        // planet.rotationSpeed = value; // Implement from ROBIN
    }

    public void OnDistanceFromStarListener(float value)
    {
        // TODO create slider and connect
        Planet planet = lastTouched.gameObject.GetComponent<Planet>();
        planet.distanceFromStar = value * 1f;
    }

    public void OnTimeScaleChange(float value)
    {
        Time.timeScale = (value * 0.32f) + 1;
    }
}
