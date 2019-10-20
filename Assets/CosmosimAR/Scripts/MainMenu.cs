using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AssetBundle assetBundle;
    private string[] scenePaths;

    public void Start()
    {
        assetBundle = AssetBundle.LoadFromFile("Scenes");
        scenePaths = assetBundle.GetAllScenePaths();
        Debug.Log("Count: " + scenePaths.Length);
    }

    public void ARGameButtonStart()
    {
        SceneManager.LoadScene("ARMode");
    }
    public void DGameButtonStart()
    {
        SceneManager.LoadScene("PrototypeScene");
    }

    public void CustomizePlanetStart()
    {
        SceneManager.LoadScene("Customize");
    }
}
