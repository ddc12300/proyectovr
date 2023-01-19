using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandStartMachine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WhacMachine"))
        {
            WhacMachineController whacMachine = other.GetComponent<WhacMachineController>();
            whacMachine.StartParty();
        }
        if (other.CompareTag("ClownMachine"))
        {
            ClownMachineController clownMachine = other.GetComponent<ClownMachineController>();
            clownMachine.StartParty();
        }
    }
}
