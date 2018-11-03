using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotateController : MonoBehaviour {

    
    float fireRate = 0.2f;
    float fireTimer = 0;
    public float speed = 6f;
    public GameObject player,Towerbullet;
    float distance;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (fireTimer > 0)
        {
            fireTimer -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Debug.Log(distance);
        Vector2 vectorToTarget = player.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.x, vectorToTarget.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.back);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
    

        if (fireTimer <= 0)
        {
            if (distance < 6)
            {
                Instantiate(Towerbullet, transform.position, transform.rotation);
            }
            fireTimer = fireRate;
            
        }

    }

    
}
