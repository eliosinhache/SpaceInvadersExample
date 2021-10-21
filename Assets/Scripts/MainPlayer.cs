using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    //Este campo se serializa por que es publico.
    public string firstName = "John";

    //Este campo no se serializa por que es privado.
    private int age = 40;

    //Este campo se serializa aunque sea privado
    //por que tiene aplicado el atributo SerializeField.
    [SerializeField]
    private bool hasHealthPotion = true;

    // Este integer será mostrado como un slider,
    // con el rango de entre 1 a 6 en el Inspector.
    [Range(1, 6)]
    public int integerRange;

    // Este float será mostrado como un slider,
    // con el rango de entre 0.2f a 0.8f en el Inspector.
    [Range(0.2f, 0.8f)]
    public float floatRange;

    [Header("Health Settings")]
    public int health = 0;
    public int maxHealth = 100;

    [Header("Shield Settings")]
    public int shield = 0;
    public int maxShield = 0;

    void Start()
    {
        if (hasHealthPotion)
            Debug.Log("Person's first name: " + firstName + " Person's age: " + age);
    }
}
