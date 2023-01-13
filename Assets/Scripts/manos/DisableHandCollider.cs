using UnityEngine;

public class DisableHandCollider : MonoBehaviour
{
    // Referencia al collider de la mano izquierda
    public Collider leftHandCollider;
    // Referencia al collider de la mano derecha
    public Collider rightHandCollider;

    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto con el que se ha colisionado no tiene el tag "pelota"
        if (other.CompareTag("mano"))
        {
            // Desactivar la propiedad "IsTrigger" del collider de la mano izquierda
            leftHandCollider.isTrigger = false;
            // Desactivar la propiedad "IsTrigger" del collider de la mano derecha
            rightHandCollider.isTrigger = false;
        }
    }
}
