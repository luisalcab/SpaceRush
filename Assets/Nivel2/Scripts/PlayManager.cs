using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    SpawnPilares spawnPilares;
    // Start is called before the first frame update
    void Start()
    {
        spawnPilares = GameObject.Find("EscenarioManager").GetComponent<SpawnPilares>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump")){
            spawnPilares.Spawn();
            Destroy(gameObject);
        }
    }
}
