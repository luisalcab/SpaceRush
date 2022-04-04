using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{
    [SerializeField]
    private int levels = 2;
    private int escenaActual = 1;

    public static Escenas Instance{
        get;
        private set;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(Instance != null){
            Destroy(gameObject);
        } else {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetEscenaActual(){
        return escenaActual;
    }

    public int GetEscenas(){
        return levels;
    }

    public void SetEscenaActual(int escena){
        escenaActual = escena;
    }
    
}
