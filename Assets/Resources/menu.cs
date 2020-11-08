using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

    public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }

    public void GoToARCamera()
    {
        Application.LoadLevel("SampleScene");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}

