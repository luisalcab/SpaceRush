using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GameO", 0.4f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GameO(){
        SceneManager.LoadScene("GameOver");
    }
}
