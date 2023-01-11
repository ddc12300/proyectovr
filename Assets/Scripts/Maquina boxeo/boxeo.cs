using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxeo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("saco"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 velocity = rb.velocity;
                float speed = velocity.magnitude;
                float score = Mathf.Clamp01(speed / 10f) * 999f;
                Debug.Log("Velocity: " + speed + " m/s");
                for (int i = 0; i <= score; i++)
                {
                    Debug.Log("Score: " + i + " points");
                }
                
            }
        }
    }
}