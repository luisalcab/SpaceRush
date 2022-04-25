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
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(){
        StartCoroutine(Pilares()); 
    }

    IEnumerator Pilares()
    {
        while(true){ 
            yield return new WaitForSeconds(1);
            Vector3 spawnPosition = new Vector3(8, Random.Range(4.5f, 7.5f), 0);
            GameObject newpilar = Instantiate(pilar, spawnPosition, pilar.transform.rotation);
            Destroy(newpilar, 4.8f);
            yield return new WaitForSeconds(wait);
        }
        
    }
}
