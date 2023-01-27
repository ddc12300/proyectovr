using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableHandCollider : MonoBehaviour
{
    // Referencia al collider de la mano izquierda
    public Collider leftHandCollider;
    // Referencia al collider de la mano derecha
    public Collider rightHandCollider;
    public GameObject Player;
    public bool check = true;
    public GameObject objectToMove;
    private Vector3 initialPosition;
    public float moveAmount = 0.5f;

    void Update()
    {

        if (check)
        {
            // Desactivar la propiedad "IsTrigger" del collider de la mano izquierda
            leftHandCollider.isTrigger = true;
            // Desactivar la propiedad "IsTrigger" del collider de la mano derecha
            rightHandCollider.isTrigger = true;

            
        }
        else
        {
            // Desactivar la propiedad "IsTrigger" del collider de la mano izquierda
            leftHandCollider.isTrigger = false;
            // Desactivar la propiedad "IsTrigger" del collider de la mano derecha
            rightHandCollider.isTrigger = false;

            

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        check = false;
        if (other.CompareTag("Player"))
        {
            initialPosition = objectToMove.transform.position;
            objectToMove.transform.position = new Vector3(objectToMove.transform.position.x, objectToMove.transform.position.y + moveAmount, objectToMove.transform.position.z);
        }

        

    }

    void Start()
    {
        StartCoroutine(Wait());
    }


    private void OnTriggerExit(Collider other)
    {
        check = true;

        if (other.CompareTag("Player"))
        {
            objectToMove.transform.position = initialPosition;
        }
    }



    IEnumerator Wait()
    {
            yield return new WaitForSeconds(1f);
            check = true;

    }



}
