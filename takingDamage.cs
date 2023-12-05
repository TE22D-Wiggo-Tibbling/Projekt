using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class takingDamage : MonoBehaviour
{




    float invincebilityTimmer = 0;
    [SerializeField]
    float invincebilitymax = 3;

    [SerializeField]
    private Rigidbody2D rb2d;

    [SerializeField]
    private float Strength = 16;



    public static string DödsAnledning = "";

    void Update()
    {

        invincebilityTimmer += Time.deltaTime;

        Debug.Log(takingDamage.DödsAnledning);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {



        if (other.gameObject.tag == "EnemyAttack" && this.gameObject.tag == "Body" && !block.blok && invincebilityTimmer > invincebilitymax)
        {
            Health.Hp--;


            Vector2 direction = new Vector2(enemyMover.slagRiktning.normalized.x * 0.3f, 1);
            rb2d.AddForce(direction * Strength, ForceMode2D.Impulse);
            rb2d.AddTorque(enemyMover.slagRiktning.normalized.x * -2, ForceMode2D.Impulse);
            invincebilityTimmer = 0;
           Health.healthBar.value=Health.Hp;
            DödsAnledning = "blev träffad för många gånger";

            
        }




        if (other.gameObject.tag == "playerAttack" && this.gameObject.tag == "enemy")
        {
            enemyMover.Hp--;


            Vector2 direction = new Vector2(slå.mouse.normalized.x, 0);
            rb2d.AddForce(direction * Strength, ForceMode2D.Impulse);


        }
    }



    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "enemy" && this.gameObject.tag == "Body" && !enemyMover.isGrounded)
        {
            Health.Hp = 0;
            DödsAnledning = "blev krossad";
        }
    }



}
