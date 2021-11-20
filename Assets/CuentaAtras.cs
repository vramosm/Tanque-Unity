using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CuentaAtras : MonoBehaviour
{

    public float Temp;
    public TextMesh Texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Se crea una cuenta atras para que cuando llegue a 0 salga en el mensaje de la pantalla

        if (Temp > 0) { 
            Temp--;
            Texto.text = "Tiempo " + Temp;

        } else
        {
            Texto.text = "¡TE HAS QUEDADO SIN GASOLINA!";
        }

    }
}
