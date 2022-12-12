using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sensitivity = 3.0f;
    public Vector2 turn;
    public Vector3 deltaMove;
    public int speed = 3;
    public GameObject ParentObj;


    void FixedUpdate()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        ParentObj.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);

        deltaMove = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ParentObj.transform.Translate(deltaMove * speed * Time.deltaTime);
    }
}
