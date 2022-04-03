using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player_L2 : MonoBehaviour
{
    [SerializeField]
    private float fuerzaSalto = 10;
    private Rigidbody rb;
    public static float globalGravity = -9.81f;
    public float gravityScale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump")){
            rb.velocity = Vector3.up * fuerzaSalto;
        }
    }

    void FixedUpdate() {
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
