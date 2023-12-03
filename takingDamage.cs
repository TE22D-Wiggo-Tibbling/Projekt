using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takingDamage : MonoBehaviour
{

    [SerializeField]
    int Hp = 2;



    [SerializeField]
    private Rigidbody2D rb2d;

    [SerializeField]
    private float EnemyStrength = 16, PlayerStrength = 16;






    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "EnemyAttack" && this.gameObject.tag == "Body")
        {
            Hp--;
            Debug.Log("höh");

            Vector2 direction = new Vector2(enemyMover.slagRiktning.normalized.x * 0.3f, 1);
            rb2d.AddForce(direction * EnemyStrength, ForceMode2D.Impulse);
            rb2d.AddTorque(enemyMover.slagRiktning.normalized.x * -2, ForceMode2D.Impulse);

        }


        if (other.gameObject.tag == "playerAttack" && this.gameObject.tag == "enemy")
        {
            enemyMover.Hp--;
            Debug.Log("höh");

            Vector2 direction = new Vector2(playerMovement.mouse.normalized.x, 0);
            rb2d.AddForce(direction * PlayerStrength, ForceMode2D.Impulse);


        }
    }


}
