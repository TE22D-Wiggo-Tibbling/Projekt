


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        Hp = Random.Range(10, 50);
        timeNeded = Random.Range(3, 7);
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
            timeNeded = Random.Range(1, 6);

        }


        Debug.Log(timeNeded);



        if (Hp == 0)
        {
            Destroy(this.gameObject);
        }


    }

    IEnumerator Slag()
    {


        yield return new WaitForSeconds(0.3f);

        Instantiate(slagPrefab, slå.transform.position + slagRiktning.normalized * 1.7f, Quaternion.Euler(0, rotation, 0));



        this.gameObject.GetComponent<Renderer>().material.color = Color.red;

    }
}
