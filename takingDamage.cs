using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takingDamage : MonoBehaviour
{





    [SerializeField]
    private Rigidbody2D rb2d;

    [SerializeField]
    private float Strength = 16;






    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "EnemyAttack" && this.gameObject.tag == "Body" && !block.blok)
        {
            Health.Hp--;


            Vector2 direction = new Vector2(enemyMover.slagRiktning.normalized.x * 0.3f, 1);
            rb2d.AddForce(direction * Strength, ForceMode2D.Impulse);
            rb2d.AddTorque(enemyMover.slagRiktning.normalized.x * -2, ForceMode2D.Impulse);
        }


        if (other.gameObject.tag == "enemy" && this.gameObject.tag == "Body" && !block.blok && !enemyMover.isGrounded)
        {
            Health.Hp = 0;
        }


        if (other.gameObject.tag == "playerAttack" && this.gameObject.tag == "enemy")
        {
            enemyMover.Hp--;


            Vector2 direction = new Vector2(slå.mouse.normalized.x, 0);
            rb2d.AddForce(direction * Strength, ForceMode2D.Impulse);


        }
    }


}
