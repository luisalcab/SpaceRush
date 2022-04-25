using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;
    private AudioSource player;
    private int pistaActual;
    
    public static SoundManager Instance{
        get;
        private set;
    }

    void Awake(){
        if(Instance != null){
            Destroy(gameObject);
        } else {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        player = GetComponent<AudioSource>();
        pistaActual = 0;

        player.clip = clips[0];

        player.mute = false;
        player.loop = true;

        player.playOnAwake = false;
        player.volume = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Nivel1(){
        pistaActual = 0;
        player.clip = clips[pistaActual];
        player.Play();
    }

    public void Nivel2(){
        pistaActual = 1;
        player.clip = clips[pistaActual];
        player.Play();
    }

    public void stopMusic(){
        player.Stop();
    }
}
