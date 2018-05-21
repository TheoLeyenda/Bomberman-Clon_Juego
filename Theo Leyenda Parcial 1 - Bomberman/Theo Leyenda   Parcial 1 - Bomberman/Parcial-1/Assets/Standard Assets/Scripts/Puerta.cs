using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour {

    // Use this for initialization
    public static int cantEnemigos = 6;
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        //Debug.Log("X:" + transform.position.x);
        //Debug.Log("Z:" + transform.position.z);
        if(cantEnemigos <= 0)
        {
            Debug.Log("Puerta Abierta");
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Jugador" && cantEnemigos <=0)
        {
            SceneManager.LoadScene("Pantalla Final");
        }
    }
}
