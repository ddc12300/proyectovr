using UnityEngine;

public class StackGenerator : MonoBehaviour
{
    public GameObject stackPrefab;
    public Vector3 startPosition = new Vector3(0, 0, 0);

    void Start()
    {
        InstantiateStack();
    }

    void InstantiateStack()
    {
        GameObject stack = Instantiate(stackPrefab, startPosition, Quaternion.identity);
    }
}
