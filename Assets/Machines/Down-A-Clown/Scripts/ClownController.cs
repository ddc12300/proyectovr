using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownController : MonoBehaviour
{
    [SerializeField] float rotYUp, rotYDown;
    [SerializeField] int points;
    [SerializeField] CapsuleCollider capsuleCollider;
    public bool isUp;

    public void Up()
    {
        isUp = true;
        transform.Rotate(0, rotYUp, 0);
        capsuleCollider.enabled = true;
    }

    public void Down()
    {
        isUp = false;
        transform.Rotate(0, rotYDown, 0);
        capsuleCollider.enabled = false;
    }

    public void BeatenClown()
    {
        Down();
        if (MachineEventsManager.BeatenClown != null) MachineEventsManager.BeatenClown(points);
    }
}
