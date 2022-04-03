using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Comportamiento de limites de juego
public class Limite : MonoBehaviour
{
    public GameObject player;

    void OnTriggerExit(Collider other) {
        if(other.gameObject != player){
            //Destruye objeto que se salga de los limites
            //del gameObject "Limite"
            Destroy(other.gameObject);
        }
    }
}
