using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encender : MonoBehaviour
{

    public GameObject button;
    GameObject presser;
    public bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        button.transform.localPosition = button.transform.localPosition + new Vector3(0, -0.1f, 0);
        presser = other.gameObject;
        isPressed = true;

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject == presser)
        {

            button.transform.localPosition = button.transform.localPosition - new Vector3(0, -0.1f, 0);
            isPressed = false;
        }

    }


}