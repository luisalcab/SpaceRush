using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Rigidbody rig;
    public GameObject explosion;
    public GameObject playerExplosion;
    public float speed;

    void Awake() {
        rig = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        rig.angularVelocity = Random.insideUnitSphere;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.tag == "Limite") return;

        Instantiate(explosion, transform.position, transform.rotation);
        if(other.CompareTag("Player")){
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0, Space.World);
    }
}
