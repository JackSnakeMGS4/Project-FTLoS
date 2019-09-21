﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int startingHP = 1000;

    private int currentHP;

    private void OnEnable()
    {
        currentHP = startingHP;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHP -= damageAmount;

        if(currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}