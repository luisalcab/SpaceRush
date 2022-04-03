using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    [SerializeField]
    float startTimer;
    float counter;
    [SerializeField]
    Text countDownTimer;
    // Start is called before the first frame update
    void Start()
    {
        counter = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0){
            counter -= Time.deltaTime;
        }
        else if (counter <= 0){
            SceneManager.LoadScene("Win");
        }

        TextoTimer();
    }

    private void TextoTimer(){
        int timeRemaining = Mathf.RoundToInt(counter);
        countDownTimer.text = String.Format("{0:00}:{1:00}", timeRemaining / 60, timeRemaining % 60);
    }
}
