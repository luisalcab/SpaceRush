using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class Player : MonoBehaviour
{
    public float velocidad = 5;
    public float tilt;
    public GameObject balaOriginal;
    public Transform referenciaDePosicion;
    public Boundary boundary;
    private Rigidbody rig;
     
    void Awake(){
        rig = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(balaOriginal, 
                referenciaDePosicion.position, 
                referenciaDePosicion.rotation);

        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        transform.position = new Vector3(Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax), 0f, Mathf.Clamp(rig.position.z, boundary.zMin, boundary.zMax));

        transform.Translate(
            velocidad * horizontal * Time.deltaTime, 
            0, 
            velocidad * vertical * Time.deltaTime, 
            Space.World
        );
        
        
        transform.rotation = Quaternion.Euler(0, 90, velocidad * vertical * tilt);
    }
}
