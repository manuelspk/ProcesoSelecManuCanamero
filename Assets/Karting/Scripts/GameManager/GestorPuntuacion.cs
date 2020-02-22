using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorPuntuacion : MonoBehaviour
{
    public static GestorPuntuacion instancia;

    public int puntuacion;      //Puntuación obtenida en la vuelta
    public int record;          //Record de mejor vuelta

    private void Awake()
    {
        instancia = this;       //Para acceder a este Script desde otros.
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActualizarRecord()
    {
        if(puntuacion>record)
        {
            record = puntuacion;
        }
    }

}
