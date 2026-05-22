using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTimer;

    public void UpdateScore(int score)
    {
        txtScore.text = "Score: " + score.ToString();
    }

    public void UpdateTimer(float tiempo)
    {
        txtTimer.text = "Time: " + tiempo.ToString("F2");
    }
}