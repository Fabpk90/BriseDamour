using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int speed = 2;
    void Update()
    {
        Vector3 temp = new Vector3();
        temp.y -= speed;
        temp.z += speed;

        if (Input.GetKey(KeyCode.Q))
        {
            temp.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            temp.x += speed;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            temp.y += speed * 2;
        }

        if (Input.GetKey(KeyCode.S))
        {
            temp.y -= speed;
        }

        temp *= Time.deltaTime;
        transform.position += temp;
    }
}
