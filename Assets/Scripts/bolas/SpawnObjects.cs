using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour
{
    public GameObject prefab;
    public GameObject container;
    public Vector3 localPosition;
    public int count;
    public int contadorbolas = 15;
    private int currentCount = 0;
    public int puntuacion = 0;

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    public void Trigger()
    {
        StartCoroutine(SpawnCoroutine2());
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