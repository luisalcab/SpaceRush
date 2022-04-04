using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Player_L2 : MonoBehaviour
{
    [SerializeField]
    private float fuerzaSalto = 10;
    private Rigidbody rb;
    public static float globalGravity;
    public float gravityScale = 1.0f;
    public GameObject GO;
    public GameObject playerExplosion;
    [SerializeField]
    private Text instrucciones;

    void Start()
    {
        rb = GetComponent <Rigidbody>();
        globalGravity = 0;
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump")){
            globalGravity = -9.81f;
            rb.velocity = Vector3.up * fuerzaSalto;
            Escenas.Instance.SetEscenaActual(SceneManager.GetActiveScene().buildIndex);
            Destroy(instrucciones); 
        }
    }

    void FixedUpdate() {
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }

    void OnTriggerExit(Collider other){

        if(other.CompareTag("Limite")){
            Instantiate(GO, GO.transform.position, GO.transform.rotation); 
            Instantiate(playerExplosion, transform.position, transform.rotation); 
            Destroy(gameObject);
        }    
    }

    void OnTriggerEnter(Collider other){

        if(other.CompareTag("Obstaculos")){
            Instantiate(GO, GO.transform.position, GO.transform.rotation); 
            Instantiate(playerExplosion, transform.position, transform.rotation); 
            Destroy(gameObject);
        }    
    }
}
