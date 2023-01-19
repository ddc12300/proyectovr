using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartellController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hamster"))
        {
            HamsterController hamster = other.GetComponent<HamsterController>();
            hamster.BeatenHamster();
        }
    }
}
