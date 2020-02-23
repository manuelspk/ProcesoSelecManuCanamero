using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.Track;
using TMPro;


//Clase para controlar lo relacionado con las colisiones del Kart.

public class KartItemCollider : MonoBehaviour
{
    public TrackManager trackManager;
    public TextMeshProUGUI Text_Monedas;

    int monedas = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Si toco una moneda, sumo 1 al contador y lo muestro en la etiqueta de juego.
        if (other.gameObject.tag=="Moneda")         
        {
            monedas++;
            Text_Monedas.text = "Coins: " + monedas.ToString();


            //Desactivo la moneda con el método de MonedaRespawn y sumo 1 al trackmanager para que contabilice el total de monedas y lo guarde en el fichero de récords.

            other.gameObject.GetComponent<MonedaRespawn>().MonedaRecogida();
            trackManager.AlRecogerMoneda();
        }
    }
}
