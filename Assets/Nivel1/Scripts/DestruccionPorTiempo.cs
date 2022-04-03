using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destruye explosiones después de tiempo
public class DestruccionPorTiempo : MonoBehaviour
{
    public float lifeTime;
    
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

}
