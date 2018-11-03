using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPosition : MonoBehaviour {

    public GameObject towerUp;

    private void fixUpdate()
    {
        transform.position = new Vector3(towerUp.transform.position.x, towerUp.transform.position.y, transform.position.z);
    }
}
