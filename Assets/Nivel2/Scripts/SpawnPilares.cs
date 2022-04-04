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
    public float height;
    // Start is called before the first frame update
    void Start()
    { 
        StartCoroutine(Pilares()); 
    }

    // Update is called once per frame
    void Update()
    {
        
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
