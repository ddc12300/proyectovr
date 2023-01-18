using UnityEngine;
using System.Collections;

public class STACKER : MonoBehaviour
{
    public GameObject prefab;
    public GameObject container;
    public Vector3 localPosition;
    public int count;
    private int currentCount = 0;

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
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
            GameObject newObject = Instantiate(prefab, container.transform.TransformPoint(localPosition), Quaternion.identity, container.transform);
            newObject.transform.localPosition = localPosition;
            newObject.transform.parent = container.transform;
            currentCount++;
        }
    }
}