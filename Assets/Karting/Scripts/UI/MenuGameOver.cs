using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Clase del menú Game Over

public class MenuGameOver : MonoBehaviour
{

    private string escenaMenu = "MainMenu";             //Nombres de las escenas a cargar.
    private string escenaJuego = "SampleScene";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Al pulsar el botón Play Again, volvemos a cargar esta escena.
    public void AlPulsarPlayAgain()
    {
        SceneManager.LoadScene(escenaJuego);
    }


    //Al pulsar el botón Back To Main Menu, volvemos a la escena inicial
    public void AlPulsarBackToMainMenu()
    {
        SceneManager.LoadScene(escenaMenu);
    }



    //Método para ocultar o mostrar el Panel del menú Game Over.
    public void On_Off_MenuGameOver(bool activo)
    {
        if (activo == false)
        {
            this.gameObject.GetComponent<CanvasGroup>().alpha = 0;
            this.gameObject.GetComponent<CanvasGroup>().interactable = false;
        }
        else if (activo==true)
        {
            this.gameObject.GetComponent<CanvasGroup>().alpha = 1;
            this.gameObject.GetComponent<CanvasGroup>().interactable = true;
        }
       
    }

}
