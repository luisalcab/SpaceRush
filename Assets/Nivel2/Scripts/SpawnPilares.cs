using System.Net.NetworkInformation;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPilares : MonoBehaviour
{
    public GameObject pilar;
    [SerializeField]
    private float wait;
    private int contAct = 0;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump")){
            if(contAct == 0){
                StartCoroutine(Pilares()); 
                contAct ++;
            }
        }
    }

    IEnumerator Pilares()
    {
        while(true){ 
            Vector3 spawnPosition = new Vector3(10, Random.Range(4.5f, 7.5f), 0);
            GameObject newpilar = Instantiate(pilar, spawnPosition, pilar.transform.rotation);
            Destroy(newpilar, 20);
            yield return new WaitForSeconds(wait);
        }
        
    }
}
