using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosPantallaFinal : MonoBehaviour {

    // Use this for initialization
    public static int puntaje;//LISTO
    public static int VidasJugador;//LISTO
    public static float EnemigosAbatidos;//LISTO
    public static int cantBloquesDestruidos;
    public static int cantPickupsAgarrados;
    public static int cantBombasSimultaneas = 1;
    public static float rangoBomba = 1;

    public Text textoPuntaje;
    public Text textoVidas;
    public Text textoEnemigosAbatidos;
    public Text textoTiempo;
    public Text textoBombasSimultaneas;
    public Text textoRangoBomba;

	void Start () {
        //puntaje = 0;
	}

    // Update is called once per frame
    void Update() {
        VidasJugador = Jugador.vidas;

        textoPuntaje.text = " " + puntaje;

        textoVidas.text = " "+VidasJugador;

        textoEnemigosAbatidos.text = " " + ((int)EnemigosAbatidos);

        textoBombasSimultaneas.text = " " + cantBombasSimultaneas;

        textoRangoBomba.text = " " + rangoBomba;
        //Debug.Log("Enemigos Abatidos:" + EnemigosAbatidos);
        //Debug.Log("Bloques destruidos:" + cantBloquesDestruidos);
        if (TiempoPartida.TiempoSegundos >= 10)
        {
            textoTiempo.text = " " + (int)TiempoPartida.TiempoMinutos + ":" + (int)TiempoPartida.TiempoSegundos;
        }
        if(TiempoPartida.TiempoSegundos <10)
        {
            textoTiempo.text = " " + (int)TiempoPartida.TiempoMinutos + ":0" + (int)TiempoPartida.TiempoSegundos;
        }
	}
}
