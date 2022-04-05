using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPilares : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public GameObject pilar;
    private bool mov;
    // Start is called before the first frame update
    void Start()
    {
        mov = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump")){
            mov = true;
        }
        if(mov == true){
            pilar.transform.Translate(speed*Time.deltaTime, 0, 0, Space.World);
        }
    }
}
