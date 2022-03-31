using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public static GUIManager Instance{
        get;
        private set;
    }
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
        SceneManager.LoadScene("Nivel1");
    }

    public void Restart(){
        SceneManager.LoadScene("Nivel1");
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
