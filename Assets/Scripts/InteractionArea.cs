using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public UIMANAGER UIMGR;
    public GameManager gameManager;


    void Awake()
    {
        UIMGR = FindObjectOfType<UIMANAGER>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            gameManager.AddScore(1);
            Debug.Log(other.gameObject.name);
        }
    }
}