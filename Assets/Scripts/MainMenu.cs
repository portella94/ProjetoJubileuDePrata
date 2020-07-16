using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EstouNoMuseu()
    {
        SceneManager.LoadScene("VuforiaCamera");
    }
    public void NaoEstouNoMuseu()
    {
        SceneManager.LoadScene("Batalha");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
