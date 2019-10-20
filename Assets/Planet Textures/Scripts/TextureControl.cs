using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureControl : MonoBehaviour
{

    MeshRenderer meshRenderer;
    public Texture Earth;
    public Texture Gas_Gaint;
    public Texture Ice_Gaint;
    public Texture Terrestrial;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void ChangeToEarth_Texture()
    {
        meshRenderer.material.SetTexture("_MainTex", Earth);
    }

    public void ChangeToGasGaint_Texture()
    {
        meshRenderer.material.SetTexture("_MainTex", Gas_Gaint);
    }

    public void ChangeToIce_Gaint_Texture()
    {
        meshRenderer.material.SetTexture("_MainTex", Ice_Gaint);
    }

    public void ChangeToTerrestrial_Texture()
    {
        meshRenderer.material.SetTexture("_MainTex", Terrestrial);
    }
}
