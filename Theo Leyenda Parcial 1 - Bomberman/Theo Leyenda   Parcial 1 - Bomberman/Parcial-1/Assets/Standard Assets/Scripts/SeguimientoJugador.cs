using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoJugador : MonoBehaviour {

    // Use this for initialization
    public GameObject fijarJugador;
    public Vector3 pocicionCam = Vector3.zero;
    public Vector3 rotacion = Vector3.zero;
    private float auxX;
    //private float auxY;
    private float auxZ;
    void Start () {
        auxX = pocicionCam.x;
        auxZ = pocicionCam.z;
        pocicionCam.x = fijarJugador.transform.position.x + (auxX);
        pocicionCam.z = fijarJugador.transform.position.z + (auxZ);
    }
	
	// Update is called once per frame
	void Update () {
        // pocicionCam.x = fijarNave.transform.position.x + camaraX;
        // pocicionCam.z = fijarNave.transform.position.z + camaraZ;
        // pocicionCam.y = fijarNave.transform.position.y + camaraY;
        //pocicionCam.x = fijarJugador.transform.position.x;
        // pocicionCam.z = fijarJugador.transform.position.z;
        pocicionCam.x = fijarJugador.transform.position.x + (auxX);
        pocicionCam.z = fijarJugador.transform.position.z + (auxZ);

        transform.rotation = Quaternion.Euler(rotacion.x, rotacion.y, rotacion.z);
        transform.position = pocicionCam;
    }
}
