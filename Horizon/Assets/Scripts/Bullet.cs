using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody2D rb;
    public int speed = 10000;
    public int dmg = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(Vector2.up * speed);

        Destroy(gameObject, 2);
    }

    


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

        }
        else
        {
            var hpC = col.gameObject.GetComponent<HPController>();

            if (hpC != null)
            {
                hpC.TakeDMG(dmg);
            }

            Destroy(gameObject);
        }
    }
}
