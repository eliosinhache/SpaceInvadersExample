using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{

    public int healt = 100;
    public Slider healtBar;

    public void ReceiveDamageAndDecreaseHealt(int amountDamage)
    {
        healt -= amountDamage;
        healtBar.value = (float) healt / 100;
    }

    public void ReceiveHealAndIncreaseHealt(int amountHeal)
    {
        healt += amountHeal;
        healtBar.value = (float) healt / 100;
    }
}
