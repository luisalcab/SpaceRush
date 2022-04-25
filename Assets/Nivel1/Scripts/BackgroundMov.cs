using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMov : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public GameObject escenario1;
    public GameObject escenario2;
    private int cont = 0;

    void Update()
    {
        escenario1.transform.Translate(speed*Time.deltaTime, 0, 0, Space.World);
        escenario2.transform.Translate(speed*Time.deltaTime, 0, 0, Space.World);
        if(escenario2.transform.position.x <= 0f){
            escenario1.transform.position = new Vector3(escenario2.transform.position.x + escenario2.GetComponent<Renderer>().bounds.size.x, escenario1.transform.position.y, escenario1.transform.position.z);
            cont = 1;
        }
        if(cont == 1){
            if(escenario1.transform.position.x <= 0f){
                escenario2.transform.position = new Vector3(escenario1.transform.position.x + escenario1.GetComponent<Renderer>().bounds.size.x, escenario2.transform.position.y, escenario2.transform.position.z);
            }
        }
    }
}
