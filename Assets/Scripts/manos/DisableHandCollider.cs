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

    }

    void Start()
    {
        StartCoroutine(Wait());
    }


    private void OnTriggerExit(Collider other)
    {
        check = true;

            
    }



    IEnumerator Wait()
    {
            yield return new WaitForSeconds(1f);
            check = true;

    }



}
