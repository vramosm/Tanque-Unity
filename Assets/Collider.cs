using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
  
    //Se crea el script para que desaparezcan las rocas 

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Roca")
        {

            Destroy(other.gameObject);
        }
    }
}
