using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Tracing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public int escenaActual;
    int levels;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CerrarAplicacion(){
        Application.Quit();
    }

    public void Begin(){
        escenaActual = Escenas.Instance.GetEscenaActual();
        if(escenaActual == 1){
            SceneManager.LoadScene("InstruccionesL1");
        }
        else{
            SceneManager.LoadScene(escenaActual);
        }
    }

    public void Restart(){
        escenaActual = Escenas.Instance.GetEscenaActual();
        SceneManager.LoadScene(escenaActual);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }

    public void NextLevel(){
        escenaActual = Escenas.Instance.GetEscenaActual();
        levels = Escenas.Instance.GetEscenas();
        if(escenaActual < levels){
            SceneManager.LoadScene(escenaActual + 1);
        }
    }

    public void startGame(){
        SceneManager.LoadScene(1);
    }

    public void Levels(){
        SceneManager.LoadScene(8);
    }

    public void Nivel1(){
        Escenas.Instance.SetEscenaActual(1);
        SceneManager.LoadScene("InstruccionesL1");
    }
    
    public void Nivel2(){
        Escenas.Instance.SetEscenaActual(2);
        SceneManager.LoadScene(2);
    }
}