using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARMenu : MonoBehaviour
{
    public void OpenMarkerAR()
    {
        StaticCode.scene_onload = "MarkerAR";
        SceneManager.LoadScene("Loading");
    }

    public void OpenScanAR()
    {
        StaticCode.scene_onload = "ScanAR";
        SceneManager.LoadScene("Loading");
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
