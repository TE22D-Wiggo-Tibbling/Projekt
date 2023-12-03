


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



    [SerializeField]
    public static float Hp = 5;

    // [SerializeField]
    float reach = 1.5f;



    [SerializeField]
    GameObject slagPrefab;

    [SerializeField]
    GameObject slå;

    float rotation;








    public static Vector3 slagRiktning = new Vector3();
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
        if (this.gameObject.transform.position.x < player.transform.position.x - reach)
        {
            float moveX = 1;

            Vector2 movementX = new Vector2(moveX, 0);

            transform.Translate(movementX * speed * Time.deltaTime);
        }

        if (this.gameObject.transform.position.x > player.transform.position.x + reach)
        {
            float moveX = -1;

            Vector2 movementX = new Vector2(moveX, 0);

            transform.Translate(movementX * speed * Time.deltaTime);
        }

        if (player.transform.position.x < this.gameObject.transform.position.x + 2 && player.transform.position.x > this.gameObject.transform.position.x - 2)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            slagTimer += Time.deltaTime;

        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }


        // ------------------------------------------------------------------------------------
        // -------------------slag-------------------------------------------------------------
        // ------------------------------------------------------------------------------------
        slagRiktning = new Vector2(player.transform.position.x - this.gameObject.transform.position.x, 0);

        if (slagRiktning.x < 0)
        {
            rotation = 180;
        }
        else
        {
            rotation = 0;
        }

        if (player.transform.position.x < this.gameObject.transform.position.x + reach && player.transform.position.x > this.gameObject.transform.position.x - reach && slagTimer > timeNeded)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;

            Instantiate(slagPrefab, slå.transform.position + slagRiktning.normalized * reach, Quaternion.Euler(0, rotation, 0));
            // transform.Translate(-slagRiktning.normalized);

            slagTimer = 0;
        }


       ;
        // transform.Translate(slagRiktning.normalized);


        if (Hp == 0)
        {
            Destroy(this.gameObject);
        }


    }

    //  private void OnTriggerEnter2D(Collider2D other) {
    //     if (other.gameObject.tag == "playerAttack"){
    //         Hp--;
    //         Debug.Log("höh");



    //     }
    // }
}
