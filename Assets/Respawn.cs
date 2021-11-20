using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //Se crea un Respawn por si el tanque se cae del escenario

    public GameObject objetoRes;

    // Start is called before the first frame update
    void Start()
    {

        objetoRes.transform.position = this.transform.position;
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.tag == "Respawn")

        this.transform.position = objetoRes.transform.position;

        
    }
}
