using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPController : MonoBehaviour {

    public int hp = 10;

    public void TakeDMG(int value)
    {
        hp -= value;
    }
}
