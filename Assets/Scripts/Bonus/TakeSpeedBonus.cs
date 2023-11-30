using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeSpeedBonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedBonus"));
        {
            BonusSpeed();
        }
    }
    public float _moveSpeedBonus;

    private void BonusSpeed()
    {
        transform.position += Vector3.down * _moveSpeedBonus * Time.deltaTime;
    }
}