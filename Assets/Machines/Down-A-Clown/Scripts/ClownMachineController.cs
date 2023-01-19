using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClownMachineController : MonoBehaviour
{
    [SerializeField] float timeParty, actualTime;
    [SerializeField] List<ClownController> clowns;
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] SphereCollider sphereCollider;
    [SerializeField] BallClownController ballClown;

    public void StartParty()
    {
        ballClown.can = true;
        if (MachineEventsManager.StartClownParty != null) MachineEventsManager.StartClownParty();
        Invoke("Timer", 1);
    }

    void Timer()
    {
        actualTime ++;
        float timeLeft = timeParty - actualTime;
        timer.text = "Timer: " + ((timeLeft <= 0) ? 0 : timeLeft);
        if (actualTime <= timeParty)
        {
            Invoke("Timer", 1);
        }
        else
        {
            FinishParty();
        }
    }

    public void FinishParty()
    {
        foreach (ClownController clown in clowns) if (!clown.isUp) clown.Up();
        actualTime = 0;
        sphereCollider.enabled = true;
        ballClown.can = false;
        if (MachineEventsManager.FinishClownParty != null) MachineEventsManager.FinishClownParty();
    }
}
