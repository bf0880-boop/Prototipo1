using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public UIMANAGER UIMGR;

    public GameObject pantallaWin;
    public GameObject pantallaLose;

    float tiempo = 60f;

    public int score = 0;
    public int maxScore = 5;

    bool gameOver = false;

    void Awake()
    {
        UIMGR = FindObjectOfType<UIMANAGER>();

        Time.timeScale = 1;
    }

    void Start()
    {
        pantallaWin.SetActive(false);
        pantallaLose.SetActive(false);
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            return;
        }

        tiempo -= Time.deltaTime;

        if (tiempo < 0)
            tiempo = 0;

        UIMGR.UpdateTimer(tiempo);
        UIMGR.UpdateScore(score);

        if (tiempo <= 0)
        {
            gameOver = true;

            pantallaLose.SetActive(true);

            Time.timeScale = 0;
        }

        if (score >= maxScore)
        {
            gameOver = true;

            pantallaWin.SetActive(true);

            Time.timeScale = 0;
        }
    }

    public void AddScore(int puntos)
    {
        score += puntos;
    }
}