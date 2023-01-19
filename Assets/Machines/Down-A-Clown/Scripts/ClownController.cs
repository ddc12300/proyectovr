using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownController : MonoBehaviour
{
    [SerializeField] float rotXUp, rotXDown;
    [SerializeField] int points;
    [SerializeField] CapsuleCollider capsuleCollider;
    public bool isUp;

    public void Up()
    {
        isUp = true;
        transform.Rotate(rotXUp, 0, 0);
        capsuleCollider.enabled = true;
    }

    public void Down()
    {
        isUp = false;
        transform.Rotate(rotXDown, 0, 0);
        capsuleCollider.enabled = false;
    }

    public void BeatenClown()
    {
        Down();
        if (MachineEventsManager.BeatenClown != null) MachineEventsManager.BeatenClown(points);
    }
}
