using System;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 forceToApply;
    private Vector3 rotateToApply;

    private Rigidbody rb;
    
    private CooldownTimer timer;

    public StudioEventEmitter emitter;

    public GameObject deathLul;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        timer = new CooldownTimer(5);
        
        timer.TimerCompleteEvent += TimerOnTimerCompleteEvent;
    }

    private void TimerOnTimerCompleteEvent()
    {
        SceneManager.LoadScene(0);
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
        
        timer.Update(Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        Die();
    }

    public void Die()
    {
        timer.Start();
        deathLul.SetActive(true);
    }

    private void FixedUpdate()
    {
        rb.AddForce(forceToApply);
        Vector3 temp = rb.velocity;
        temp.z = speed;
        rb.velocity = temp;
        
        emitter.SetParameter("CVSpeed",  Mathf.Clamp(rb.velocity.magnitude * 500, 0, 1000));
        emitter.SetParameter("Portance",  Mathf.Clamp(rb.velocity.y * 500, 0, 5000));
    }
}
