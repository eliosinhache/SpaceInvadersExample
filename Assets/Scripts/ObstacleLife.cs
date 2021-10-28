using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLife : MonoBehaviour
{
    public int life = 3;

    public void ReceiveDamage()
    {
        life -= 1;
        if (life == 0) { Destroy(gameObject); }
    }
}
