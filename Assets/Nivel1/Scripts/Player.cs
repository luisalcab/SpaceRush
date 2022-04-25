using System.Diagnostics.Tracing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

//Comportamiento del jugador
public class Player : MonoBehaviour
{
    public float velocidad = 5;
    public float tilt;
    public GameObject balaOriginal;
    public Transform referenciaDePosicion;
    public Boundary boundary;
    private Rigidbody rig;
    [SerializeField]
    private GameObject contador;
    [SerializeField]
    private AudioClip[] clips;
    private AudioSource sounds;
     
    void Awake(){
        rig = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        sounds = GetComponent<AudioSource>();
        SoundManager.Instance.Nivel1();
        Instantiate(contador, transform.position, Quaternion.identity);
    }

    void Update()
    {
        //Saca balas
        //Al menos un ejemplo de objetos instanciados dinámicamente (18%)
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Bala")){
            Instantiate(balaOriginal, 
                referenciaDePosicion.position, 
                Quaternion.identity);
            sounds.clip = clips[0];
            sounds.volume = 0.5f;
            sounds.Play();
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        //Evita salida de player de pantalla
        transform.position = new Vector3(Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax), 0f, Mathf.Clamp(rig.position.z, boundary.zMin, boundary.zMax));

        //Personaje que se mueve en 4 direcciones utilizando ejes
        //Se debe poder probar con gamepad. (17%)
        transform.Translate(
            velocidad * horizontal * Time.deltaTime, 
            0, 
            velocidad * vertical * Time.deltaTime, 
            Space.World
        );
        
        
        transform.rotation = Quaternion.Euler(0, 90, velocidad * vertical * tilt);
    }
}
