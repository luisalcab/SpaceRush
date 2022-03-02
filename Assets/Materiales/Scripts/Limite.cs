using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update

    void OnTriggerExit(Collider other) {
        if(other.gameObject != player){
            Destroy(other.gameObject);
        }
    }
}
