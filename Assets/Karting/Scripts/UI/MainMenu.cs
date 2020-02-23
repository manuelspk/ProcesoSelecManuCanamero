using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KartGame.KartSystems;
using KartGame.Track;
using TMPro;

//Clase del menú principal.

public class MainMenu : MonoBehaviour
{

    private string escenaJuego = "SampleScene";       //Nombre de la escena a cargar al pulsar el botón Play.

    public TrackRecord m_HistoricalBestLap;             //Donde voy a cargar los datos del recor de la mejor vuelta.
    public string trackName;                            //Nombre del circuito. Necesario para cargar record de mejor vuelta.

    public TextMeshProUGUI Text_mejorVuelta;
    public TextMeshProUGUI Text_TotalMonedas;
    string m_Path;


    public void Start()
    {
        LeerRecords();                                  //Lee el fichero con el récord y acualiza la etiqueta del menú.

    }




    public void AlPulsarPlay()                             //Al pulsar el botón Play de la escena Main Menu
    {
        SceneManager.LoadScene(escenaJuego);
    }



    public void AlPulsarExit()                               //Al pulsar el botón Exit de la escena MainMenu
    {
        Application.Quit();                             //Cerramos el juego
    }



    public void ReiniciarRecords()                          //Reinicio los records. Guardo en el fichero un TrackRecord vacío y actualizo el Label del menú   
    {
        TrackRecord.Save(TrackRecord.CreateDefault());
        LeerRecords();
    }



    void LeerRecords()                                      //Lee el fichero con el récord y acualiza la etiqueta del menú.
    {
        m_HistoricalBestLap = TrackRecord.Load(trackName, 1);   //Cargo el record guardado de la mejor vuelta y el total de monedas.

        if(m_HistoricalBestLap.time.ToString()=="Infinity")     //En caso de que no existan récords de mejor vuelta, muestro el mensaje "No Records". Si no, muestro la mejor vuelta guardada en el fichero.
        {
            Text_mejorVuelta.text = "Best Lap: No Records";
        }
        else
        {
            Text_mejorVuelta.text = "Best Lap: " + m_HistoricalBestLap.time.ToString("F2");
        }

        
        Text_TotalMonedas.text = "Coins: " + m_HistoricalBestLap.monedas.ToString();
    }

}

