using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basquet : MonoBehaviour
{
    private int puntuacion = 0;
    private IEnumerator coroutine;
    public float targetTime = 60.0f;
    public bool openTrigger = false;
 
void Update(){
 
Debug.Log("Tiempo: " + Mathf.RoundToInt( targetTime ));
Debug.Log("Puntuación: " + puntuacion);
 
if(openTrigger){
    targetTime -= Time.deltaTime;
}
 
 if (targetTime <= 0.0f)
 {
    timerEnded();
 }
 
 }
 
 void timerEnded()
 {
    Debug.Log("Puntuación final: " + puntuacion);
    openTrigger = false;
    targetTime = 60.0f;
    puntuacion = 0;
 }

  void Start () {
        
}

    private void OnTriggerEnter(Collider other)
    {
    	    openTrigger = true;
            puntuacion ++;
            coroutine = Timer();
            StartCoroutine(coroutine);
        
    }


    IEnumerator Timer()
        {
            yield return new WaitForSeconds(1);
        }

}
