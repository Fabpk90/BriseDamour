using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform toFollow;
    void Update()
    {
        // suit l'objet sur les axes y et z
        transform.position = new Vector3(offset.x, offset.y + toFollow.position.y, offset.z + toFollow.position.z);
    }
}
