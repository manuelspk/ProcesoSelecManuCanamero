using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MonedaRecogida()
    {
        StartCoroutine(EsperaParaActivar());
    }



    public void MonedaActiva(bool activo)
    {
        if(activo==true)
        {
            this.gameObject.GetComponent<Renderer>().enabled = true;
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        else if(activo==false)
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }



    IEnumerator EsperaParaActivar()
    {
        MonedaActiva(false);
        yield return new WaitForSeconds(5);
        MonedaActiva(true);
    }
}
