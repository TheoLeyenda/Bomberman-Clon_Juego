using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoPartida : MonoBehaviour {

    // Use this for initialization
    public static float TiempoSegundos = 0;//LISTO
    public static float TiempoMinutos = 0;//LISTO
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TiempoSegundos = TiempoSegundos + Time.deltaTime;
        if (TiempoSegundos >= 60)
        {
            TiempoSegundos = 0;
            TiempoMinutos++;
        }
    }
}
