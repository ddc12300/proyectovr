using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnObjects : MonoBehaviour
{
    public GameObject prefab;
    public GameObject container;
    public Vector3 localPosition;
    public int count;
    private int currentCount = 0;
    public int contadorbolas = 60;
    private int puntuacion = 0;
    public TMP_Text tiempoUI;
    public TMP_Text puntuacionUI;

    public string tiempo;

    void Update()
    {

        tiempo = contadorbolas.ToString();

        tiempoUI.text = tiempo;

        puntuacionUI.text = puntuacion.ToString();

    }


    void Start()
    {
        tiempoUI.text = contadorbolas.ToString();

        puntuacionUI.text = puntuacion.ToString();

        StartCoroutine(SpawnCoroutine());
    }

    public void Trigger(int puntos)
    {
        if (contadorbolas > 0)
        {
            puntuacion = puntuacion + puntos;
            StartCoroutine(SpawnCoroutine2());
            contadorbolas--;
        }

    }

    IEnumerator SpawnCoroutine()
    {
        for (int i = 0; i < count; i++)
        {
            Spawn();
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void Spawn()
    {
        if (currentCount < count)
        {
            GameObject newObject = Instantiate(prefab, container.transform.TransformPoint(localPosition), Quaternion.identity);
            newObject.transform.parent = container.transform;
            currentCount++;
        }
    }

    public void Spawn2()
    {

        GameObject newObject = Instantiate(prefab, container.transform.TransformPoint(localPosition), Quaternion.identity);
        newObject.transform.parent = container.transform;

    }

    IEnumerator SpawnCoroutine2()
    {
        yield return new WaitForSeconds(1f);
        Spawn2();
    }

}
