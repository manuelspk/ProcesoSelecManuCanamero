using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    private string escenaMenu = "MainMenu";
    private string escenaJuego = "SampleScene";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlPulsarPlayAgain()
    {
        SceneManager.LoadScene(escenaJuego);
    }



    public void AlPulsarBackToMainMenu()
    {
        SceneManager.LoadScene(escenaMenu);
    }



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
