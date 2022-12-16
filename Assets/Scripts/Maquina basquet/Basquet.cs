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

    public string tiempo = "60";
    public string puntuacionString = "0";
 
void Update(){

        //string text1 = Mathf.RoundToInt( targetTime ).ToString();
        //string text2 = puntuacion.ToString();

        //tiempoUI.SetText(text1);
        //puntuacionUI.SetText(text2);

        tiempo = Mathf.RoundToInt(targetTime).ToString();
        //print(Mathf.RoundToInt(targetTime));


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
        //tiempoUI = GameObject.Find("tiempo").GetComponent<TextMeshProUGUI> ();
        //puntuacionUI = GameObject.Find("puntuacion").GetComponent<TextMeshProUGUI> ();
        tiempoUI.text = tiempo;

        puntuacionUI.text = puntuacionString;
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
