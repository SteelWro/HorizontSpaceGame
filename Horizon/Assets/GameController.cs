using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Sprite[] sprites;

    public GameObject star;
    public float speedF, speedM, speedC;

    private void Awake()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                GameObject temp = Instantiate(star, new Vector3(i*2 + 0.2f, j* 2 + 0.2f, 0), transform.rotation);
                BackgroundStar tempBG = temp.GetComponent<BackgroundStar>();
                tempBG.speed = speedC;
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                GameObject temp = Instantiate(star, new Vector3(i * 2 - 0.2f, j * 2 - 0.2f, 0), transform.rotation);
                BackgroundStar tempBG = temp.GetComponent<BackgroundStar>();
                tempBG.speed = speedM;
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                GameObject temp = Instantiate(star, new Vector3(i * 2, j * 2, 0), transform.rotation);
                BackgroundStar tempBG = temp.GetComponent<BackgroundStar>();
                tempBG.speed = speedF;
            }
        }
        GameObject.FindGameObjectWithTag("Star").GetComponent<BackgroundStar>().PopulateSprites();
    }
}
