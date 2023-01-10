using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basquet : MonoBehaviour
{
    private int puntuacion = 0;
    private IEnumerator coroutine;
    public float targetTime = 60.0f;
    public bool openTrigger = false;
    public TMP_Text tiempoUI;
    public TMP_Text puntuacionUI;

    public string tiempo;
 
void Update(){

        tiempo = Mathf.RoundToInt(targetTime).ToString();

        tiempoUI.text = tiempo;

        puntuacionUI.text = puntuacion.ToString();


        if (openTrigger){
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
        tiempoUI.text = Mathf.RoundToInt(targetTime).ToString();

        puntuacionUI.text = puntuacion.ToString();
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
