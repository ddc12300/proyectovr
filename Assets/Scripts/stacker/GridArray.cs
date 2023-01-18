using UnityEngine;

public class GridArray : MonoBehaviour
{
    public GameObject prefab;
    public int gridWidth = 10;
    public int gridHeight = 10;
    public float spacing = 1;

    private void Start()
    {
        // Crear una matriz de objetos vacíos
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
        // Detectar las teclas de dirección presionadas
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Mover el objeto vacío a la posición correcta en el grid
        Vector3 pos = transform.position;
        pos.x += x * spacing;
        pos.z += z * spacing;
        transform.position = pos;
    }
}