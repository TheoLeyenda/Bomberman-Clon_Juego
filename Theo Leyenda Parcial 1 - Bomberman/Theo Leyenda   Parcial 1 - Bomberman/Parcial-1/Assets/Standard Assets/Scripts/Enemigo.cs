using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum estados
{
    PARADO,
    MOVIMIENTO,
}
public class Enemigo : MonoBehaviour {

    // Use this for initialization
    private estados estado;
    private int x;
    private int z;
    public float random = 1;
    private float cambioDirecion = 0;
    private float cambioDirecion1 = 2f;
    private float cambioDirecion2 = 2f;
    private float cambioDirecion3 = 2f;
    private float cambioDirecion4 = 2f;

	void Start () {
        estado = estados.PARADO;
	}

    // Update is called once per frame
    void Update() {

        cambioDirecion = cambioDirecion - Time.deltaTime;
        if(cambioDirecion1 >= 0)
        {
            cambioDirecion1 = cambioDirecion1 - Time.deltaTime;
        }
        if(cambioDirecion2 >= 0)
        {
            cambioDirecion2 = cambioDirecion2 - Time.deltaTime;
        }
        if (cambioDirecion3 >= 0)
        {
            cambioDirecion3 = cambioDirecion3 - Time.deltaTime;
        }
        if(cambioDirecion4 >= 0)
        {
            cambioDirecion4 = cambioDirecion4 - Time.deltaTime;
        }
        if (cambioDirecion <= 0)
        {
            estado = estados.PARADO;
        }
        switch (estado)
        {
 
            case estados.PARADO:
                random = Random.Range(1, 5);
                cambioDirecion = 2f;
                estado = estados.MOVIMIENTO;
                
                //calcular el proximo random
                break;
            case estados.MOVIMIENTO:
                if (cambioDirecion > 0)
                {
                    if (random == 1 && cambioDirecion1 <= 0)
                    {
                        x = -5;
                        z = 0;
                        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, 0, z);
                        cambioDirecion1 = 2f;
                    }
                    if (random == 2 && cambioDirecion2 <= 0)
                    {
                        x = 5;
                        z = 0;
                        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, 0, z);
                        cambioDirecion2 = 2f;
                    }
                    if (random == 3 && cambioDirecion3 <= 0)
                    {
                        z = -5;
                        x = 0;
                        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, 0, z);
                        cambioDirecion3 = 2f;
                    }
                    if (random == 4 && cambioDirecion4 <=0)
                    {
                        z = 5;
                        x = 0;
                        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, 0, z);
                        cambioDirecion4 = 2f;
                    }
                    
                }
                //calcular si coliciono contra algo
                break;
        }
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, 0, z);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemigo")
        {
            
            if (estado == estados.MOVIMIENTO)
            {
                if(random == 1)
                {
                    random = 2;
                }
                if(random == 2)
                {
                     random = 1;
                }
                if(random == 3)
                {
                     random = 4;
                }
                if(random == 4)
                {
                   random = 3;
                }
                
                z = z * -1;
                x = x * -1;
                cambioDirecion1 = 2f;
                cambioDirecion2 = 2f;
                cambioDirecion3 = 2f;
                cambioDirecion4 = 2f;
                cambioDirecion = 2f;
                //random = 50;
               //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, 0, z);*/
            }
        }
    }
}
