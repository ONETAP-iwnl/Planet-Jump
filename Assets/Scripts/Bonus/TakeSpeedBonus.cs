using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeSpeedBonus : MonoBehaviour
{
    public static Action OnSpeedBonus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedBonus"))
        {
            OnSpeedBonus?.Invoke();
        }
    }
}