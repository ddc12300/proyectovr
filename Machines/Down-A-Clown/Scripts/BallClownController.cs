using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallClownController : MonoBehaviour
{
    public bool can;

    public Transform spawner;

    [SerializeField] float timeToReturn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InsideClown")) Invoke("ReturnSpawnerPosition", timeToReturn);

        if (!can) return;
        if (other.CompareTag("Clown"))
        {
            ClownController clown = other.GetComponent<ClownController>();
            clown.BeatenClown();
        }
    }

    void ReturnSpawnerPosition()
    {
        transform.position = spawner.position;
    }
}
