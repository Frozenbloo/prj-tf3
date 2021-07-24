using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

    public Rigidbody rb;

    [Header("Slide")]
    [SerializeField] public float slideForce = 0.01f;


    public void slide()
    {
        rb.AddForce(transform.forward * slideForce, ForceMode.Impulse);
        print("Slide");
    }



}
