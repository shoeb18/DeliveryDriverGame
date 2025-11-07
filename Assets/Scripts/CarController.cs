using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 0.01f;
    [SerializeField] private float rotateSpeed = 0.1f;

    void Start()
    {
        
    }

    void Update()
    {
        // Input
        float horizontalInput = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Movement
        transform.Rotate(0, 0, -horizontalInput);
        transform.Translate(0, verticalInput,0);
    }
}
