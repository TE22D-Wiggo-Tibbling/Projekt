


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyMover : MonoBehaviour
{

    [SerializeField]
    float slagTimer = 0;


    float timeNeded = 10;

    [SerializeField]
    float speed = 5;
    [SerializeField]
    Transform player;





    [SerializeField]
    float reach = 1.5f;



    [SerializeField]
    GameObject slagPrefab;

    [SerializeField]
    GameObject slå;



    float rotation;


    public static float Hp;


    public static Vector3 slagRiktning = new Vector3();


    [SerializeField]
    LayerMask groundLayer;

    Vector2 size = new Vector2(1.5f, 1.5f);

    public static bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        Hp = Random.Range(10, 50);
        timeNeded = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapBox(this.gameObject.transform.position, size, 0, groundLayer);

        if (isGrounded)
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

            if (player.transform.position.x < this.gameObject.transform.position.x + reach && player.transform.position.x > this.gameObject.transform.position.x - reach)
            {

                slagTimer += Time.deltaTime;

            }


            // ------------------------------------------------------------------------------------
            // -------------------slag-------------------------------------------------------------
            // ------------------------------------------------------------------------------------


            slagRiktning = new Vector2(player.transform.position.x - this.gameObject.transform.position.x, 0);



            if (player.transform.position.x < this.gameObject.transform.position.x + reach && player.transform.position.x > this.gameObject.transform.position.x - reach && slagTimer > timeNeded)
            {
                this.gameObject.GetComponent<Renderer>().material.color = Color.green;

                StartCoroutine(Slag());
                slagTimer = 0;
                timeNeded = Random.Range(0, 3);

            }
        }


        Debug.Log(timeNeded);


        if (Hp == 0)
        {
            // --------------------------------------------------------------------------------------------
            // -----------------------------------------temporärt------------------------------------------
            // --------------------------------------------------------------------------------------------
            this.gameObject.transform.position = new Vector2(Random.Range(-6, 6), 20.0f);
            Hp = Random.Range(10, 50);
            Points.instance.AddPoint();
        }
        Debug.Log(isGrounded);
    }

    IEnumerator Slag()
    {


        yield return new WaitForSeconds(0.3f);

        Instantiate(slagPrefab, slå.transform.position + slagRiktning.normalized * 1.7f, Quaternion.Euler(0, rotation, 0));



        this.gameObject.GetComponent<Renderer>().material.color = Color.red;

    }
}
