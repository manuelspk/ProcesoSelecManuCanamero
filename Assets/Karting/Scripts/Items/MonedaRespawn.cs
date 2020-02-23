using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Clase Moneda
public class MonedaRespawn : MonoBehaviour
{
    
    //Método para llamar cuando se recoja una moneda. Llama a una corrutina que desactiva el objeto durante 5 segundos.
    public void MonedaRecogida()
    {
        StartCoroutine(EsperaParaActivar());
    }


    //Método para activar o desactivar la moneda.
    public void MonedaActiva(bool activo)
    {
        if(activo==true)
        {
            //Desactivo su mesh y su collider, para que pueda volver a aparece a los 5 segundos. Si lo desactivara, no ejecutaría la corrutina.
            this.gameObject.GetComponent<Renderer>().enabled = true;
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        else if(activo==false)
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }



    //Corrutina para volver a activar la moneda a los 5 segundos.
    IEnumerator EsperaParaActivar()
    {
        MonedaActiva(false);
        yield return new WaitForSeconds(5);
        MonedaActiva(true);
    }
}
