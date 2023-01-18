using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    public float moveSpeed = 1f;
    private Vector3 gridSize;
    private Vector3 initialPosition;
    private GameObject block;
    private bool moveForward = true;
    private Rigidbody blockRigidbody;

    void Start()
    {
        gridSize = GameObject.Find("Grid").transform.lossyScale;
        initialPosition = transform.position;
        block = Instantiate(blockPrefab, transform.position, Quaternion.identity);
        blockRigidbody = block.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (moveForward)
            blockRigidbody.velocity = new Vector3(0f, 0f, moveSpeed);
        else
            blockRigidbody.velocity = Vector3.zero;

        block.transform.position = new Vector3(
            block.transform.position.x,
            block.transform.position.y,
            Mathf.Clamp(block.transform.position.z, initialPosition.z - (gridSize.z / 2), initialPosition.z + (gridSize.z / 2))
        );
    }

}
