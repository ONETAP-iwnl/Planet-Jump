using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestory : MonoBehaviour
{
    [SerializeField]
    GameObject DiedCanvas;
    [SerializeField]
    GameObject GameCanvas;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Meteor"))
        {
            

            DeadScene();
            Invoke("DiedCanvas", 3f);
        }
    }

    private void DestroyRocket()
    {
        
    }
    public void DeadScene()
    {
        Time.timeScale = 0;
        GameCanvas.SetActive(false);
        DiedCanvas.SetActive(true);
    }
}
