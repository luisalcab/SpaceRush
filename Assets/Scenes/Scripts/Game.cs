using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    
    public GameObject peligro;
    public Vector3 spawnValues;
    public int cantAsteroids;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while(true){
            for(int i = 0; i < cantAsteroids; i++){
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
                Instantiate(peligro, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
        
    }
}
