using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast: MonoBehaviour {

public bool openTrigger = false;
private IEnumerator coroutine;


void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Debug.Log("Golpeado");
            openTrigger = true;
        }
        else
        {
            Debug.Log("Nada sin golpear");
            coroutine = Timerboton();
            StartCoroutine(coroutine);
        }
    }

    IEnumerator Timerboton()
        {
            yield return new WaitForSeconds(1);
            openTrigger = false;
        }

}
