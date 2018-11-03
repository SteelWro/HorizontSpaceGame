using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidS : MonoBehaviour {

    Rigidbody2D rb;
    public HPController hpC;

    // Use this for initialization
    void Start()
    {
        transform.Rotate(0f, 0f, Random.Range(0, 360f));
        hpC = GetComponent<HPController>();

        float maxV = 100;
        float minV = 50;

        rb = GetComponent<Rigidbody2D>();

        float x = Random.Range(minV, maxV);
        float y = Random.Range(minV, maxV);

        

        rb.AddRelativeForce(new Vector2(x, y));
    }

    private void Update()
    {
        if (hpC.hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
