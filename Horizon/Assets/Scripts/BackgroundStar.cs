using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStar : MonoBehaviour
{

    public static Sprite[] sprites;
    public GameObject star;
    SpriteRenderer starSprite;

    public float speed;
    public float staritngX;
    public float startingY;

    float positionX;
    float positionY;
    

    Vector3 direction;

    public static int border = 12;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        starSprite = star.GetComponent<SpriteRenderer>();
        RandomSprite();


    }

    private void Update()
    {
        positionX = transform.position.x - GameObject.FindGameObjectWithTag("Camera").transform.position.x;
        positionY = transform.position.y - GameObject.FindGameObjectWithTag("Camera").transform.position.y;
        //Camera.main.transform.position.y

        if (positionX >= border)
        {
            transform.position = new Vector3(transform.position.x - 2*border, transform.position.y, transform.position.z);
            // transform.position = new Vector3(Camera.main.transform.position.x - border + (positionX - border), transform.position.y, transform.position.z);
            RandomSprite();
        }

        if (positionX <= -border)
        {
            transform.position = new Vector3(transform.position.x + 2*border, transform.position.y, transform.position.z);
            //transform.position = new Vector3(Camera.main.transform.position.x + border + (-border - positionX), transform.position.y, transform.position.z);
            RandomSprite();
        }

        if (positionY >= border)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 2*border, transform.position.z);
            //transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y - border + (positionY - border), transform.position.z);
            RandomSprite();
        }

        if (positionY <= -border)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2 * border, transform.position.z);
            //transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y + border + (-border - positionY), transform.position.z);
            RandomSprite();
        }


        direction = rb.velocity;
        transform.position += direction * speed * 0.002f;


    }

    void RandomSprite()
    {
        starSprite.sprite = sprites[Random.Range(0, sprites.Length)];
        star.transform.position = transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), transform.position.z);
    }

    public void PopulateSprites()
    {
        sprites = GameObject.FindGameObjectWithTag("Ctrl").GetComponent<GameController>().sprites;
    }
}
