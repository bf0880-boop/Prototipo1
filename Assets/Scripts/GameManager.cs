using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIMANAGER UIMGR;

    float tiempo = 60f;
    public int score = 0;
    public int maxScore = 4;

    bool gameOver = false;
    void Awake()
    {
        UIMGR = FindObjectOfType<UIMANAGER>();
    }
    void Update()
    {
        if (gameOver)
            return;

        tiempo -= Time.deltaTime;
        if (tiempo < 0)
            tiempo = 0;
        UIMGR.UpdateTimer(tiempo);
        UIMGR.UpdateScore(score);
        if (tiempo <= 0)
        {
            gameOver = true;
            Debug.Log("LOSS");
        }
        if (score >= maxScore)
        {
            gameOver = true;
            Debug.Log("WIN");
        }
    }
    public void AddScore(int puntos)
    {
        score += puntos;
    }
}