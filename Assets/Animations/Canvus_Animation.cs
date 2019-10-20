using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvus_Animation : MonoBehaviour
{
    private Animator menuAnim;
    private bool menuOn = true;


    private void Awake()
    {
        menuAnim = GetComponent<Animator>();
    }

    public void BeginMenu()
    {
        if (menuOn)
        {
            menuAnim.SetTrigger("FadeIn");
            menuOn = false;
        }
        else {
            menuOn = true; 
        }
    }
}
