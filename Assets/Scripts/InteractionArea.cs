using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public UIMANAGER UIMGR;
    public int score = 0;


    void Awake(){
        UIMGR = GameObject.FindObjectOfType<UIMANAGER>();
    }

   void OnTriggerEnter(Collider other){
    if(other.gameObject.CompareTag("Collectible")){
        Destroy(other.gameObject);
        score++;
        UIMGR.UpdateScore(score);
    }

    Debug.Log(other.gameObject.name);
   }
}
