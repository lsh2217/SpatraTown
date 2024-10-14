using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.position;
        desiredPosition.z = -10;
        transform.position = desiredPosition;
    }
}