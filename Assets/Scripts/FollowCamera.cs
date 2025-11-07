using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private float zOffset;

    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(0,0,zOffset); 
    }
}
