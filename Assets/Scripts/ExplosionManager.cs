using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;
    private AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void ExplosionPlayer(){
        player.clip = clips[0];
        player.volume = 0.2f;
        player.Play();
    }

    public void ExplosionAsteroid(){
        player.clip = clips[1];
        player.volume = 0.2f;
        player.Play();
    }
    
}
