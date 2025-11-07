using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField] private float normalMoveSpeed = 5f;
    [SerializeField] private float boostMoveSpeed = 10f;
    [SerializeField] private float rotateSpeed = 0.1f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = normalMoveSpeed;
    }

    void Update()
    {
        // Input
        float horizontalInput = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        // Movement
        transform.Rotate(0, 0, -horizontalInput);
        transform.Translate(0, verticalInput, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedUp"))
        {
            currentSpeed = boostMoveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        currentSpeed = normalMoveSpeed;
    }
}
