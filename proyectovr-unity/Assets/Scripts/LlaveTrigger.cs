using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveTrigger : MonoBehaviour
{
    public bool openTrigger = false;
    private IEnumerator coroutine;

  void Start () {
        
}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            openTrigger = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Key"))
        {
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
