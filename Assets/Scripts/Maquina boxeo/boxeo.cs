using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boxeo : MonoBehaviour
{
    public TMP_Text record1;
    public TMP_Text record2;
    private IEnumerator coroutine;
    private int puntuacion = 0;

    // Start is called before the first frame update
    void Start()
    {
        record1.text = puntuacion.ToString(); 

        record2.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        record1.text = puntuacion.ToString();
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
                float score = Mathf.Clamp01(speed / 5f) * 999f;
                Debug.Log("Velocity: " + speed + " m/s");
                for (int i = 0; i <= score; i++)
                {
                    puntuacion = i;
                    Debug.Log("Score: " + i + " points");
                    coroutine = Timer();
                    StartCoroutine(coroutine);
                }
                
            }
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
    }
}