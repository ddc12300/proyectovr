using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    public int cantidadpuntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherObject = GameObject.FindGameObjectWithTag("Bolas");
        SpawnObjects script = otherObject.GetComponent<SpawnObjects>();
        script.Trigger();
        Destroy(other.gameObject, 1f);
    }



}
