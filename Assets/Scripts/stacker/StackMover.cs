using UnityEngine;

public class StackMover : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 leftBound = new Vector3(-5, 0, 0);
    public Vector3 rightBound = new Vector3(5, 0, 0);
    private bool moveRight = true;

    void Update()
    {
        if (moveRight)
            transform.position = Vector3.MoveTowards(transform.position, rightBound, speed * Time.deltaTime);
        else
            transform.position = Vector3.MoveTowards(transform.position, leftBound, speed * Time.deltaTime);

        if (transform.position == rightBound)
            moveRight = false;
        if (transform.position == leftBound)
            moveRight = true;
    }

}
