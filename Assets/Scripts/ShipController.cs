using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector2 movement;
    public AudioSource shootingSound;
    public GameObject bullet;

    public float speed = 1f;

    // Se llama a Start antes de la primera actualización del cuadro

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update se llama una vez por frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector2(moveHorizontal, 0f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Acá lo importante es aprender la función Instatiate(). En este caso
            // el primer parámetro el Prefab que queremos instanciar, el segundo
            // parámetro es la posición donde lo vamos instanciar (en este caso la posición de la nave)
            // y el tercero es la rotación del Prefab que se está instanciando.
            Instantiate(bullet, transform.position + new Vector3(0f, 0.7f, 0f), transform.rotation);
            shootingSound.Play();
        }
    }

    // FixedUpdate se llama en cada fixed frame-rate frame. (50 llamadas por segundo, por defecto)
    void FixedUpdate()
    {
        // Aplica la fuerza al Rigidbody2d
        rigidbody.AddForce(movement * speed * 5f);
    }
}
