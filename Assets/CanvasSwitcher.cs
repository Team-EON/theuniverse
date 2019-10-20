using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public static bool stage = true;
    void Start()
    {
        ToggleControllers();
    }

    public void UpdateCanvas(string canvasName, bool shouldHide)
    {
        Debug.Log("Updating canvas");
        GameObject[] gameobjs = GameObject.FindGameObjectsWithTag(canvasName);
        foreach(GameObject gobj in gameobjs)
        {
            Hider rect = gobj.GetComponent<Hider>();
            rect.Hide(shouldHide);
        }
    }

    public void ToggleControllers()
    {
        if (stage)
        {
            ShowSimulatorButtons();
        } else
        {
            ShowCustomizationButtons();
        }
        stage = !stage;
    }
    public void ShowSimulatorButtons()
    {
        Time.timeScale = 1f;
        UpdateCanvas("Canvas1", false);
        UpdateCanvas("Canvas2", true);
    }

    public void ShowCustomizationButtons()
    {
        Time.timeScale = 0f;
        UpdateCanvas("Canvas1", true);
        UpdateCanvas("Canvas2", false);
    }
}
