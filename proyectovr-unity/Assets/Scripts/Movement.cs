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


        deltaMove = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ParentObj.transform.Translate(deltaMove * speed * Time.deltaTime);
    }
}
