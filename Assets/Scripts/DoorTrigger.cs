using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public bool openTrigger = false;
    private IEnumerator coroutine;

  void Start () {
        
}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personatge")
        {
            openTrigger = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Personatge")
        {
            coroutine = Timer();
            StartCoroutine(coroutine);
        }
        
    }

    IEnumerator Timer()
        {
            yield return new WaitForSeconds(1);
            openTrigger = false;
        }

}