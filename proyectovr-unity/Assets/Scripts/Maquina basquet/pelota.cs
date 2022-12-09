using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    [SerializeField] float fuerzadelrebote;
    private void OnCollisionEnter(Collision collision)
    {
            Rigidbody rb = collision.rigidbody;
            rb.AddExplosionForce(fuerzadelrebote, collision.contacts[0].point, 5);
    }
}

