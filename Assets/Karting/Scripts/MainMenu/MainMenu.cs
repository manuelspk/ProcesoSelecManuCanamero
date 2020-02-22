using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string escenaACargar = "SampleScene";      //Nombre de la escena a cargar al pulsar el botón Play.



    public void AlPulsarPlay()                             //Al pulsar el botón Play de la escena Main Menu
    {
        SceneManager.LoadScene(escenaACargar);
    }

    public void AlPulsarExit()                             //Al pulsar el botón Exit de la escena MainMenu
    {
        Application.Quit();                         //Cerramos el juego
    }
}
