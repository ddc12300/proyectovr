using System.Collections;
using UnityEngine;
using TMPro;

public class boxeo : MonoBehaviour
{
    public TMP_Text record1;
    public TMP_Text record2;
    public int puntuacion = 0;
    public Rigidbody rb2;
    public bool isPaused;
    public int tempScore;
    public int highestScore;
    public float maxSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        record1.text = "0";
        record2.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (tempScore < puntuacion)
        {
            tempScore++;
            record1.text = tempScore.ToString();
            PauseHingeJoint();
        }

        if (tempScore == puntuacion)
        {
            if (isPaused)
            {
                StartCoroutine(ResumeHingeJoint());
            }

            if (puntuacion > highestScore)
            {
                highestScore = puntuacion;
                record2.text = highestScore.ToString();
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(!isPaused)
        {
            if (other.CompareTag("saco"))
            {
                Rigidbody rb = other.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    Vector3 velocity = rb.velocity;
                    float speed = Mathf.Clamp(velocity.magnitude, 0, maxSpeed);
                    float score = Mathf.Clamp(speed / maxSpeed, 0, 1) * 999f;
                    Debug.Log("Velocity: " + speed + " m/s");
                    puntuacion = (int)score;
                    Debug.Log("Score: " + puntuacion + " points");
                }
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
        rb2.isKinematic = false;
        yield return new WaitForSeconds(3);
        isPaused = false;
        puntuacion = 0;
        tempScore = 0;
        record1.text = puntuacion.ToString();
    }
}
