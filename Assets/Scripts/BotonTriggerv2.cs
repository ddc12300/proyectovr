using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonTriggerv2 : MonoBehaviour
{
    public bool openTrigger = false;
    private IEnumerator coroutine;

  void Start () {
        
}

    private void OnCollisionEnter(Collision other)
    {
    
            if (openTrigger == false)
            {
            	openTrigger = true;
            }else{
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
