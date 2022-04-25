using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public GameObject escenario1;
    public GameObject escenario2;
    [SerializeField]
    private GameObject contador;
    private int contAct = 0;
    private bool mov;
    private int cont = 0;
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
            if(contAct == 0){
                Instantiate(contador, transform.position, Quaternion.identity);
                contAct ++;
            }
        }
        if(mov == true){
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
}
