using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tanque : MonoBehaviour
{
    public CuentaAtras cuentaAtras;
    public float Temp;
    public float Speed;
    public float SpeedRot;
    public GameObject Bala;
    public GameObject Cañon;
    public bool bReady;
    public float fireRate = 0.5f;
    private float ultimoDisparo;
 
    // Start is called before the first frame update
    void Start()
    {

        ultimoDisparo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        //Se crean los movimientos y el disparo del tanque con la condicion de estar dentro del tiempo
        if (cuentaAtras.Temp > 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, 0, 1) * Speed * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, 0, -1) * Speed * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, -1, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 1, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }

            // Se crea el disparo, configurando el rate, la cadencia y la trayqectoria del disparo
            if (Input.GetKeyDown(KeyCode.Space))
            { if (ultimoDisparo < Time.time)
                {
                    ultimoDisparo = Time.time + fireRate;
                    GameObject g = Instantiate(Bala, Cañon.transform.position, Cañon.transform.rotation);
                    g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 1000);
                }

            }
        }
        else
        {
            End();

        }
    }
    void End()
    {
        //se crea este apartado para que salga en la consola, poniendo el destroy para que solo salga una vez el mensaje
        Debug.Log("¡TE HAS QUEDADO SIN GASOLINA!");
        Destroy(this);

    }
}
