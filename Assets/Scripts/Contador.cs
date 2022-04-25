using System.Net.Sockets;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Diagnostics.Tracing;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public class Contador : MonoBehaviour
{
    [SerializeField]
    float startTimer;
    float counter;
    [SerializeField]
    Text countDownTimer;
    int escenaActual;
    int levels;
    SoundManager sound;
    
    void Start()
    {
        sound = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        counter = startTimer;
        escenaActual = Escenas.Instance.GetEscenaActual();
        levels = Escenas.Instance.GetEscenas();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0){
            counter -= Time.deltaTime;
        }
        else if (counter <= 0){
            sound.stopMusic();
            if(escenaActual == levels){
                Load.scene = "Final";
                SceneManager.LoadScene("Load");
            }
            else{
                Load.scene = "Win";
                SceneManager.LoadScene("Load");
            }
        }

        TextoTimer();
    }

    private void TextoTimer(){
        int timeRemaining = Mathf.RoundToInt(counter);
        countDownTimer.text = String.Format("{0:00}:{1:00}", timeRemaining / 60, timeRemaining % 60);
    }
}
