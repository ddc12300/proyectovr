using UnityEngine;
using System.Collections;

public class STACKER : MonoBehaviour
{
    public GameObject prefab;
    public GameObject container;
    public Vector3 localPosition;
    public int count;
    private int currentCount = 0;
    private float offset = 1f;

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
            GameObject newObject = Instantiate(prefab, container.transform.TransformPoint(localPosition + new Vector3(offset * currentCount, 0, 0)), Quaternion.identity);
            newObject.transform.localPosition = localPosition;
            newObject.transform.parent = container.transform;
            currentCount++;
        }
    }
}