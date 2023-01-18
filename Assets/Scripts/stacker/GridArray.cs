using UnityEngine;

public class GridArray : MonoBehaviour
{
    public GameObject prefab;
    public int gridWidth = 10;
    public int gridHeight = 10;
    public float spacing = 1;

    private void Start()
    {
        // Crear una matriz de objetos vac�os
        for (int i = 0; i < gridWidth; i++)
        {
            for (int j = 0; j < gridHeight; j++)
            {
                Vector3 pos = new Vector3(i * spacing, 0, j * spacing);
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        // Detectar las teclas de direcci�n presionadas
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Mover el objeto vac�o a la posici�n correcta en el grid
        Vector3 pos = transform.position;
        pos.x += x * spacing;
        pos.z += z * spacing;
        transform.position = pos;
    }
}