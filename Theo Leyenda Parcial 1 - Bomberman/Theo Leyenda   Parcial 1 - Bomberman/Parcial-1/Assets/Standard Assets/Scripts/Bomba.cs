using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour {

    // Use this for initialization
    public GameObject bombita;
    public static float rango = 1f;
    private float danio = 1;
    private Vector3 direcion;
    public float tiempoExplocion = 3;
    [HideInInspector]//oculta la variable que esta abajo.
    public bool ExplocionRepentina = false;
    private float randomPickup;
    private float maxRandomPickup= 8;
    public GameObject powerUp1;
    public GameObject powerUp2;
    public GameObject powerUp3;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tiempoExplocion = tiempoExplocion - Time.deltaTime;

        if (tiempoExplocion <= 0)
        {
            RaycastHit hit;
            if (Physics.BoxCast(transform.position,new Vector3(0.1f,0.1f,0.1f),transform.forward,out hit, transform.rotation, rango))
            {
                if (hit.transform.gameObject.tag == "Destructible" || hit.transform.gameObject.tag == "Enemigo")
                {
                    if (hit.transform.gameObject.tag == "Enemigo")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 100;
                        Puerta.cantEnemigos--;
                        DatosPantallaFinal.EnemigosAbatidos = DatosPantallaFinal.EnemigosAbatidos + 1;
                    }
                    if(hit.transform.gameObject.tag == "Destructible")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 50;
                        DatosPantallaFinal.cantBloquesDestruidos = DatosPantallaFinal.cantBloquesDestruidos + 1;

                        randomPickup = Random.Range(0, maxRandomPickup);
                        //Debug.Log("pick:"+randomPickup);
                        if((int)randomPickup == 0)
                        {
                            Instantiate(powerUp1, hit.transform.position,Quaternion.identity);
                        }
                        if((int)randomPickup == 2)
                        {
                            Instantiate(powerUp2, hit.transform.position, Quaternion.identity);
                        }
                        if((int)randomPickup == 5)
                        {
                            Instantiate(powerUp3, hit.transform.position, Quaternion.identity);
                        }
                            
                    }
                    Destroy(hit.transform.gameObject);  
                }
                if(hit.transform.gameObject.tag == "Bomba")
                {
                    //hit.transform.gameObject.GetComponent<Bomba>().ExplocionRepentina = true;
                    hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion = 0;
                    Debug.Log("Tiempo explocion:"+hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion);
                }
                if (hit.transform.gameObject.tag == "Jugador" )
                {
                    Jugador.vidas = Jugador.vidas -1;
                    hit.transform.position = new Vector3(0, 0, 0);
                }
            }
            if(Physics.BoxCast(transform.position, new Vector3(0.1f, 0.1f, 0.1f), transform.forward*-1, out hit, transform.rotation, rango))
            {
                if (hit.transform.gameObject.tag == "Destructible" || hit.transform.gameObject.tag == "Enemigo")
                {
                    if (hit.transform.gameObject.tag == "Enemigo")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 100;
                        Puerta.cantEnemigos--;
                        DatosPantallaFinal.EnemigosAbatidos = DatosPantallaFinal.EnemigosAbatidos + 1;
                    }
                    if (hit.transform.gameObject.tag == "Destructible")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 50;
                        DatosPantallaFinal.cantBloquesDestruidos = DatosPantallaFinal.cantBloquesDestruidos + 1;

                        randomPickup = Random.Range(0, maxRandomPickup);
                        //Debug.Log("pick:" + randomPickup);
                        if ((int)randomPickup == 0)
                        {
                            Instantiate(powerUp1, hit.transform.position, Quaternion.identity);
                        }
                        if ((int)randomPickup == 2)
                        {
                            Instantiate(powerUp2, hit.transform.position, Quaternion.identity);
                        }
                        if ((int)randomPickup == 5)
                        {
                            Instantiate(powerUp3, hit.transform.position, Quaternion.identity);
                        }
                    }
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.gameObject.tag == "Bomba")
                {
                    //hit.transform.gameObject.GetComponent<Bomba>().ExplocionRepentina = true;
                    hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion = 0;
                    Debug.Log("Tiempo explocion:" + hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion);
                }
                if (hit.transform.gameObject.tag == "Jugador")
                {
                    Jugador.vidas = Jugador.vidas -1;
                    hit.transform.position = new Vector3(0, 0, 0);
                }
            }
            if(Physics.BoxCast(transform.position, new Vector3(0.1f, 0.1f, 0.1f), transform.right, out hit, transform.rotation, rango))
            {
                if (hit.transform.gameObject.tag == "Destructible" || hit.transform.gameObject.tag == "Enemigo")
                {
                    if (hit.transform.gameObject.tag == "Enemigo")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 100;
                        Puerta.cantEnemigos--;
                        DatosPantallaFinal.EnemigosAbatidos = DatosPantallaFinal.EnemigosAbatidos + 1;
                    }
                    if (hit.transform.gameObject.tag == "Destructible")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 50;
                        DatosPantallaFinal.cantBloquesDestruidos = DatosPantallaFinal.cantBloquesDestruidos + 1;

                        randomPickup = Random.Range(0, maxRandomPickup);
                        //Debug.Log("pick:" + randomPickup);
                        if ((int)randomPickup == 0)
                        {
                            Instantiate(powerUp1, hit.transform.position, Quaternion.identity);
                        }
                        if ((int)randomPickup == 2)
                        {
                            Instantiate(powerUp2, hit.transform.position, Quaternion.identity);
                        }
                        if ((int)randomPickup == 5)
                        {
                            Instantiate(powerUp3, hit.transform.position, Quaternion.identity);
                        }
                    }
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.gameObject.tag == "Bomba")
                {
                    hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion = 0;
                    Debug.Log("Tiempo explocion:" + hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion);
                }
                if (hit.transform.gameObject.tag == "Jugador")
                {
                    Jugador.vidas = Jugador.vidas - 1;
                    hit.transform.position = new Vector3(0, 0, 0);
                }
            }
            if(Physics.BoxCast(transform.position, new Vector3(0.1f, 0.1f, 0.1f), transform.right *-1, out hit, transform.rotation, rango))
            {
                if (hit.transform.gameObject.tag == "Destructible" || hit.transform.gameObject.tag == "Enemigo")
                {
                    if (hit.transform.gameObject.tag == "Enemigo")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 100;
                        Puerta.cantEnemigos--;
                        DatosPantallaFinal.EnemigosAbatidos = DatosPantallaFinal.EnemigosAbatidos + 1;
                    }
                    if (hit.transform.gameObject.tag == "Destructible")
                    {
                        DatosPantallaFinal.puntaje = DatosPantallaFinal.puntaje + 50;
                        DatosPantallaFinal.cantBloquesDestruidos = DatosPantallaFinal.cantBloquesDestruidos + 1;

                        randomPickup = Random.Range(0, maxRandomPickup);
                        //Debug.Log("pick:" + randomPickup);
                        if ((int)randomPickup == 0)
                        {
                            Instantiate(powerUp1, hit.transform.position, Quaternion.identity);
                        }
                        if ((int)randomPickup == 2)
                        {
                            Instantiate(powerUp2, hit.transform.position, Quaternion.identity);
                        }
                        if ((int)randomPickup == 5)
                        {
                            Instantiate(powerUp3, hit.transform.position, Quaternion.identity);
                        }
                    }
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.gameObject.tag == "Bomba")
                {
                    hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion = 0;
                    Debug.Log("Tiempo explocion:" + hit.transform.gameObject.GetComponent<Bomba>().tiempoExplocion);
                }
                if (hit.transform.gameObject.tag == "Jugador")
                {
                    Jugador.vidas = Jugador.vidas - 1;
                    hit.transform.position = new Vector3(0, 0, 0);
                }
            }
            Destroy(transform.gameObject);
        }
	}
}
