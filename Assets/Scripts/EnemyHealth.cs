﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //[SerializeField]
    private Grunt enemy;
    Animator anim;
    public float enemyHealth = 100f;

    private void Start()
    {
        enemy = GetComponent<Grunt>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (enemyHealth <= 0f)
        {
            EnemyDeath();
        }
    }

    /*public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;

        if (enemyHealth <= 0)
        {
            enemy.EnemyDeathAnim();
            EnemyDeath();
        }
    }*/

    void EnemyDeath()
    {
        anim.SetTrigger("isDead");
        //enemy.EnemyDeathAnim();
        Destroy(gameObject, 1f);
    }
}
