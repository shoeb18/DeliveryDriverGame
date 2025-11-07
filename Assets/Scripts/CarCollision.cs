using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Destroy(collision.gameObject, 0.35f);
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Debug.Log("Package Picked!!");
        }
        if (collision.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = Color.white;
            Debug.Log("Package Delivered!!");
        }
    }
}


