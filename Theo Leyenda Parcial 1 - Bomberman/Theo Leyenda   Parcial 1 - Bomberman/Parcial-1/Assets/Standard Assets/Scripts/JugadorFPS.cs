using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorFPS : MonoBehaviour {

    // Use this for initialization
    public Camera fpsCamera;
    public Camera mainCamera;
    public float VelocidadHorizontal;
    public float VelocidadVertical;
    private float vertical;
    private float horizontal;
    private bool esFPS = false;
	
	// Update is called once per frame
	void Update () {
		if(esFPS == true)
        {
            vertical = VelocidadVertical* Input.GetAxis("Mouse Y");
            horizontal = VelocidadHorizontal* Input.GetAxis("Mouse X");
            transform.Rotate(0, horizontal, 0);
            fpsCamera.transform.Rotate(-vertical, 0, 0);
        }
        else
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            esFPS = false;
            fpsCamera.gameObject.SetActive(false);
            mainCamera.gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            esFPS = true;
            fpsCamera.gameObject.SetActive(true);
            mainCamera.gameObject.SetActive(false);
        }
	}
}
