using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        //Esta sencilla función hará que la bala avance hacia adelante
        transform.position = transform.position + transform.up * speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.LogWarning("colisiona con algo");
        if (col.collider.name!= "Ship")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);            
        }
    }
}
