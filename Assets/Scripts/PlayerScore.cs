using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textoScore;

    public void IncreaseScore(int amount)
    {
        score += amount;
        textoScore.text = "Score Actual: " + score.ToString();
    }
}
