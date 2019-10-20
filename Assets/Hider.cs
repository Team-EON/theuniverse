using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hider : MonoBehaviour
{
    public Vector3 dest = new Vector3(-5, -5, -5);
    public Vector3 initialPosition;

    private void Awake()
    {
        RectTransform rect = GetComponent<RectTransform>();
        initialPosition = rect.position;
    }

    public void Hide(bool shouldHide)
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.position = shouldHide ? dest : initialPosition;
    }
}
