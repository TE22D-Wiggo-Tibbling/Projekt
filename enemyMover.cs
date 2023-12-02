


using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyMover : MonoBehaviour
{

    [SerializeField]
    float slagTimer = 0;

    [SerializeField]
    float timeNeded = 10;

    [SerializeField]
    float speed = 5;
    [SerializeField]
    GameObject player;

    float tillbaka;

    [SerializeField]
    float Hp = 5;


    Vector2 slagRiktning = new Vector2();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //------------------------------------------------------------------------------
        // --------------------------movement-------------------------------------------
        // -----------------------------------------------------------------------------
        if (this.gameObject.transform.position.x < player.transform.position.x - 2)
        {
            float moveX = 1;

            Vector2 movementX = new Vector2(moveX, 0);

            transform.Translate(movementX * speed * Time.deltaTime);
        }

        if (this.gameObject.transform.position.x > player.transform.position.x + 2)
        {
            float moveX = -1;

            Vector2 movementX = new Vector2(moveX, 0);

            transform.Translate(movementX * speed * Time.deltaTime);
        }

        if (player.transform.position.x < this.gameObject.transform.position.x + 2 && player.transform.position.x > this.gameObject.transform.position.x - 2)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            slagTimer += Time.deltaTime;
            tillbaka += Time.deltaTime;
        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }


        // ------------------------------------------------------------------------------------
        // -------------------slag-------------------------------------------------------------
        // ------------------------------------------------------------------------------------
        slagRiktning.x = this.gameObject.transform.position.x - player.transform.position.x;

        if (player.transform.position.x < this.gameObject.transform.position.x + 2 && player.transform.position.x > this.gameObject.transform.position.x - 2 && slagTimer > timeNeded && slagTimer < timeNeded + 0.01)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;


            transform.Translate(-slagRiktning.normalized);

        }
        if (tillbaka > timeNeded + 0.1)
        {

            slagTimer = 0;
            tillbaka = 0;
            transform.Translate(slagRiktning.normalized);
        }

        if (Hp==0)
        {
            Destroy(this.gameObject);
        }


    }

     private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "playerAttack"){
            Hp--;
            Debug.Log("höh");
        }
    }
}
