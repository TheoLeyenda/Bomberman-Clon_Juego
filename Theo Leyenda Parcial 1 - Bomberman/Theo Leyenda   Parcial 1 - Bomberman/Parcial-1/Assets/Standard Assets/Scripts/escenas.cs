using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escenas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Jugador.vidas);
        if(Jugador.vidas <= 0)
        {
            SceneManager.LoadScene("Pantalla Final");

        }
	}
    public void LoadJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    public void LoadPantallaInicial()
    {
        SceneManager.LoadScene("Pantalla Inicial");
    }
    public void LoadPantallaFinal()
    {
        SceneManager.LoadScene("Pantalla Final");
    }
}
