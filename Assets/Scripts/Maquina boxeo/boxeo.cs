using System.Collections;
using UnityEngine;
using TMPro;

public class boxeo : MonoBehaviour
{
    public TMP_Text record1;
    public TMP_Text record2;
    private int puntuacion = 0;
    public Rigidbody rb2;
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        record1.text = "0";
        record2.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        record1.text = puntuacion.ToString();
        record2.text = puntuacion.ToString();
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
                puntuacion = (int)score;
                Debug.Log("Score: " + puntuacion + " points");
                PauseHingeJoint();
                StartCoroutine(ResumeHingeJoint());
            }
        }
    }

    private void PauseHingeJoint()
    {
        isPaused = true;
        rb2.isKinematic = true;
    }

    private IEnumerator ResumeHingeJoint()
    {
        yield return new WaitForSeconds(3);
        isPaused = false;
        rb2.isKinematic = false;
    }
}
