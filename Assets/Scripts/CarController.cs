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
        transform.Rotate(0, 0, rotateSpeed);
        transform.Translate(0, moveSpeed,0);
    }
}
