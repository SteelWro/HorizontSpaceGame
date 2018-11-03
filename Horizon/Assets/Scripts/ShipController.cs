using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    Rigidbody2D rb;
    public int speed = 1;
    public int maxSpeed = 3;

    public int rotationSpeed = 5;

    public GameObject bullet;

    float fireRate = 0.1f;
    float fireTimer = 0;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(fireTimer > 0)
        {
            fireTimer -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {

        if (rb != null)
        {
            
            if(rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
               
            }


             
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddRelativeForce(Vector2.up * speed);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddRelativeForce(Vector2.down * speed);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * rotationSpeed);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.forward * -rotationSpeed);
            }


     
            if (Input.GetKey(KeyCode.Space))
            {
                if (fireTimer <= 0)
                {
                    Instantiate(bullet, transform.position, transform.rotation);
                    fireTimer = fireRate;
                }
                
            }



        }

        
    }
}
