using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 forceToApply;
    private Vector3 rotateToApply;

    private Rigidbody rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        forceToApply = new Vector3();
        rotateToApply = new Vector3(-90, -90, 0);

        // Left movement
        if (Input.GetKey(KeyCode.Q))
        {
            forceToApply.x -= speed * 3f;
            rotateToApply.x += 10;
        }

        // Right movement
        if (Input.GetKey(KeyCode.D))
        {
            forceToApply.x += speed * 3f;
            rotateToApply.x -= 10;
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

        transform.rotation = Quaternion.Euler(rotateToApply);
    }

    private void FixedUpdate()
    {
        rb.AddForce(forceToApply);
        Vector3 temp = rb.velocity;
        temp.z = speed;
        rb.velocity = temp;
    }
}
