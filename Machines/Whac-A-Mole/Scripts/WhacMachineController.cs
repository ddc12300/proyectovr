using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhacMachineController : MonoBehaviour
{
    [SerializeField] List<HamsterController> hamsters;
    [SerializeField] float timeParty, timeToGetAHamster, timeHamsterIsOut, actualTime;
    [SerializeField] int amountOfHamsterOutside;
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] SphereCollider sphereCollider;

    public void StartParty()
    {
        sphereCollider.enabled = false;
        if (MachineEventsManager.StartWhacParty != null) MachineEventsManager.StartWhacParty();
        Invoke("ClimbHamsters", timeToGetAHamster);
    }

    void ClimbHamsters()
    {
        actualTime += timeToGetAHamster;
        float timeLeft = timeParty - actualTime;
        timer.text = "Timer: " + ((timeLeft <= 0)?0:timeLeft);
        if (actualTime <= timeParty)
        {
            InvokeHamsters();
            Invoke("ClimbHamsters", timeToGetAHamster);
        }
        else
        {
            FinishParty();
        }
    }

    void InvokeHamsters()
    {
        for (int i = 0; i < amountOfHamsterOutside; i++)
        {
            int randomIndex = Random.Range(0, hamsters.Count-1);
            if (!hamsters[randomIndex].isUp)
            {
                hamsters[randomIndex].Up();
                StartCoroutine(GetDownHamster(hamsters[randomIndex]));
            }
        }
    }

    IEnumerator GetDownHamster(HamsterController hamster)
    {
        yield return new WaitForSeconds(timeHamsterIsOut);
        if (hamster.isUp) hamster.Down();
    }

    public void FinishParty()
    {
        foreach (HamsterController hamster in hamsters) hamster.Down();
        actualTime = 0;
        sphereCollider.enabled = true;
        if (MachineEventsManager.FinishWhacParty != null) MachineEventsManager.FinishWhacParty();
    }
}
