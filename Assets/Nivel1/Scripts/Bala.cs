using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Comportamiento de balas
public class Bala : MonoBehaviour
{

    void Update()
    {
        //Movimiento de bala
        transform.Translate(8*Time.deltaTime, 0, 0, Space.World);
    }
}
