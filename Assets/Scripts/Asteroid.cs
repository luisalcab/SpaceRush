using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Comportamiento del asteroide / asteroides
public class Asteroid : MonoBehaviour
{
    private Rigidbody rig;
    public GameObject explosion; //Efecto de explosion asteroides-bala
    public GameObject playerExplosion; //Efecto de explosion player-asteroides
    public float speed;
    public GameObject ui;
    public Vector3 posicion;


    void Awake() {
        rig = GetComponent<Rigidbody>();
    }
    

    void Start()
    {
        rig.angularVelocity = Random.insideUnitSphere;  //Gira el asteroide
    }

    //Debe haber al menos un ejemplo de detección de colisiones 
    //que sea congruente con tu tipo de juego (17%)
    void OnTriggerEnter(Collider other){
        if(other.tag == "Limite") return; //Evita colisiones con objeto limite

        //Objeto instanciado dinámicamente, crea explosiones
        Instantiate(explosion, transform.position, transform.rotation); 
        if(other.CompareTag("Player")){
            //Objeto instanciado dinámicamente, crea explosiones
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation); 
            Instantiate(ui, posicion, ui.transform.rotation);
        }
        Destroy(other.gameObject); //Destruye objeto que colisiona con asteroide
        Destroy(gameObject); //Destruye asteroide que chocó
        
    }

    void Update()
    {
        //Movimiento recto de asteroides
        transform.Translate(speed*Time.deltaTime, 0, 0, Space.World); 
    }

}
