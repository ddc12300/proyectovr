using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveTriggerNoTag : MonoBehaviour
{
    public bool openTrigger = false;
    private IEnumerator coroutine;

  void Start () {
        
}

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "Llave")
        {
            openTrigger = true;
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Llave")
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
