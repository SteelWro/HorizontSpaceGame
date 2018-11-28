using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    Rigidbody2D rb;
    public HPController hpC;
    public GameObject asteroidS;
    public ParticleSystem ps;

    

	// Use this for initialization
	void Start () {
        transform.Rotate(0f, 0f, Random.Range(0, 360f));

        hpC = GetComponent<HPController>();

        float maxV = 50;
        float minV = -50;

        rb = GetComponent<Rigidbody2D>();

        float x = Random.Range(minV, maxV);
        float y = Random.Range(minV, maxV);

        rb.AddForce(new Vector2(x, y));
	}

    private void Update()
    {
        if(hpC.hp <=0)
        {
            Die();
        }
    }

    void Die()
    {
             
        Instantiate(asteroidS, transform.position + new Vector3(-0.25f, 0), transform.rotation);
        Instantiate(asteroidS, transform.position + new Vector3(0.25f, 0), transform.rotation);
        Instantiate(ps, transform.position, transform.rotation);

        Destroy(gameObject);
    }

}
