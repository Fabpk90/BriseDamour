using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 8f;
    public Vector3 forceToApply;
    private Rigidbody rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        forceToApply = new Vector3();

        // Left movement
        if (Input.GetKey(KeyCode.Q))
        {
            forceToApply.x -= speed * 3f;
        }

        // Right movement
        if (Input.GetKey(KeyCode.D))
        {
            forceToApply.x += speed * 3f;
        }


        // Up movement
        if (Input.GetKey(KeyCode.Z))
        {
            forceToApply.y += speed * 6f;
        }

        // Down movement
        if (Input.GetKey(KeyCode.S))
        {
            forceToApply.y -= speed * 3f;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(forceToApply);
        Vector3 temp = rb.velocity;
        temp.z = speed;
        rb.velocity = temp;
    }
}
