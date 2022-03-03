using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Control de juego
public class Game : MonoBehaviour
{
    //Peligro = hazard = asteroides
    public GameObject peligro;
    public Vector3 spawnValues;
    public int cantAsteroids;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        //Empieza función que instancia los asteroides
        StartCoroutine(SpawnWaves()); 
    }

    
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait); 
        //Instancia asteroides
        while(true){ 
            for(int i = 0; i < cantAsteroids; i++){
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, Random.Range(-spawnValues.z, spawnValues.z));
                //Objetos instanciados dinámicamente
                Instantiate(peligro, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
            //Tiempo de espera de cada "horda" de asteroides 
            yield return new WaitForSeconds(waveWait);
        }
        
    }
}
