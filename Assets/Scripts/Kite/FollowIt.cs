using UnityEngine;

public class FollowIt : MonoBehaviour
{
    public Transform toFollow;
    public float timeOffset;
    public Vector3 posOffest;

    private Vector3 velocity;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, toFollow.position + posOffest, ref velocity, timeOffset);
    }
}
