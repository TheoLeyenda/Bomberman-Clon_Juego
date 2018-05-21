using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    // Use this for initialization
    private int x;
    private int z;
    //private float xBomba = 0;
    // private float yBomba = 0;
    private float dileyBomba = 3.1f;
    public static int vidas = 2;
    public GameObject bomba;
    private int puntoMiraX = 1;
    private int puntoMiraZ = 1;
    private float quitarVidaDiley = 2;
    private bool quitarVida = false;
    private float speed = 10;
    public Rigidbody rb;
    private int limiteBombasSimultanias = 1;
    private int bombasSimultaneas = 0;
    //public Rigidbody rig;

    private float centerX;
    private float centerZ;
    private Vector3 pos;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (quitarVidaDiley <= 2)
        {
            quitarVidaDiley = quitarVidaDiley + Time.deltaTime;
        }
        //MOVIMIENTO
        rb.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            rb.velocity = transform.right * -1 * speed;
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            rb.velocity = transform.right * speed;
        if (Input.GetKey(KeyCode.W))
            rb.velocity = transform.forward * speed;
        if (Input.GetKey(KeyCode.S))
            rb.velocity = transform.forward * -1 * speed;
       
        if (Input.GetKeyDown(KeyCode.Space) && bombasSimultaneas < limiteBombasSimultanias || Input.GetButtonDown("Fire1") && bombasSimultaneas < limiteBombasSimultanias )
        {
            DatosPantallaFinal.cantBombasSimultaneas = DatosPantallaFinal.cantBombasSimultaneas - 1;
            bombasSimultaneas++;
            if(bombasSimultaneas >= limiteBombasSimultanias)
            {
                dileyBomba = 3.1f;
            }
            gameObject.layer = 9;
            centerX = centerZ = 0;
            pos = transform.position;
            pos.x = Mathf.Abs(pos.x);
            pos.z = Mathf.Abs(pos.z);
            while ((pos.x + 0.5f) > 1)
            {
                centerX++;
                pos.x--;
            }
            while ((pos.z + 0.5f) > 1)
            {
                centerZ++;
                pos.z--;
            }
            Instantiate(bomba, new Vector3(centerX * -1, transform.position.y, centerZ), Quaternion.identity);
           
        }
        if(transform.position.x> (centerX*-1) + 1 || transform.position.x< (centerX*-1) -1 || transform.position.z > centerZ + 1 || transform.position.z < centerZ -1)
        {
            gameObject.layer = 10;
        }
        if (dileyBomba > 0)
        {
            dileyBomba = dileyBomba - Time.deltaTime;
        }
        if (dileyBomba <= 0)
        {
            bombasSimultaneas = 0;
            dileyBomba = 3.1f;
            
            DatosPantallaFinal.cantBombasSimultaneas = limiteBombasSimultanias;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo" && quitarVidaDiley>=2)
        {
            transform.position = new Vector3(0, 0, 0);
            vidas = vidas - 1;
            quitarVidaDiley = 0;
        }
        //POWER UP - vida extra(anda).
        if(collision.gameObject.tag == "vidaExtra")
        {
            Debug.Log("VIDA EXTRA!");
            vidas = vidas + 1;
            Destroy(collision.gameObject);
        }
        //POWER UP - mas rango a la bomba(anda).
        if (collision.gameObject.tag == "masRango")
        {
            Debug.Log("MAS RANGO!");
            Bomba.rango = Bomba.rango + 1;
            DatosPantallaFinal.rangoBomba = Bomba.rango;
            Destroy(collision.gameObject);
        }
        //POWER UP - bomba extra(anda).
        if(collision.gameObject.tag == "BombasInfinitas")
        {
            Debug.Log("BOMBA EXTRA!");
            limiteBombasSimultanias++;
            DatosPantallaFinal.cantBombasSimultaneas = limiteBombasSimultanias;
            Destroy(collision.gameObject);
        }
    }
}
