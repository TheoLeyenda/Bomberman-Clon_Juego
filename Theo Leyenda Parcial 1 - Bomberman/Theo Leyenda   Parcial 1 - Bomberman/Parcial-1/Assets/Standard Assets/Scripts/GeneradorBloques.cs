using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBloques : MonoBehaviour {

    // Use this for initialization
    public GameObject bloqueDestructible;
    public GameObject puerta;
    private GameObject[] cajita;
    private float random;
    private float RandomPuerta;
    void Start() {
        for (int i = 0; i <= 14; i++)
        {
            for (int j = 0; j <= 16; j++)
            {
                random = Random.Range(0, 5);
                if (random == 0)
                {
                    if ((j % 2 == 0) || (j % 2 != 0) && (i % 2 == 0))
                    {
                        if (((i == 12 && j == 4) || (i == 2 && j == 4) || (i == 2 && j == 14) || (i == 12 && j == 14) || (i == 7 && j == 10) || (i == 7 && j == 8) || (i == 0 && j == 0)) == false)
                        {
                            Instantiate(bloqueDestructible, new Vector3(i * -1, 0, j), Quaternion.identity);
                        }
                    }
                }
            }
        }
        cajita = GameObject.FindGameObjectsWithTag("Destructible");//Cargo el array con todos los objetos instanciados 
                                                                   //que tengan el tag pasado por parametro
        RandomPuerta = Random.Range(0, cajita.Length);
        Instantiate(puerta, cajita[(int)RandomPuerta].transform.position, Quaternion.identity);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
