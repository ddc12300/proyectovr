using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterController : MonoBehaviour
{
    [SerializeField] float posZUp, posZDown;
    [SerializeField] int points;
    [SerializeField] SphereCollider sphereCollider;
    public bool isUp;

    public void Up()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, posZUp);
        sphereCollider.enabled = true;
        isUp = true;
    }

    public void Down()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, posZDown);   
        sphereCollider.enabled = false;
        isUp = false;
    }

    public void BeatenHamster()
    {
        Down();
        if (MachineEventsManager.BeatenHamster != null) MachineEventsManager.BeatenHamster(points);
    }
}
