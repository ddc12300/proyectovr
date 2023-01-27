using UnityEngine;

public class movy : MonoBehaviour
{
    private Vector3 initialPosition;
    public float moveAmount = 2f;

    void OnTriggerEnter(Collider other)
    {
        initialPosition = transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y + moveAmount, transform.position.z);
    }

    void OnTriggerExit(Collider other)
    {
        transform.position = initialPosition;
    }
}
