using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{

    [SerializeField]
    float speed = 3;

    [SerializeField]
    float jumpforce = 100;

    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    float groundRadius = 0.4f;

    [SerializeField]
    LayerMask groundLayer;

    [SerializeField] 
    float health = 3.0f;

      [SerializeField]
    Transform slag;

    bool mayJump = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");

        Vector2 movementX = new Vector2(moveX, 0);


        transform.Translate(movementX * speed * Time.deltaTime);

        // bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
        Vector3 size = MakeGroundcheckSize();
        bool isGrounded = Physics2D.OverlapBox(groundCheck.position, size, 0,groundLayer);


        if (Input.GetAxisRaw("Jump") > 0 && mayJump == true && isGrounded == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector2 jump = Vector2.up * jumpforce;

            rb.AddForce(jump);

            mayJump = false;
        }


        if (Input.GetAxisRaw("Jump") == 0)
        {
            mayJump = true;
        }

      
    }


  private void OnTriggerEnter2D(Collider2D other) {
             if (other.gameObject.tag == "enemy")
        {
            health--;
            if(health<1){
                  Destroy(this.gameObject);
            }
        }
       
        }



    void OnDrawGizmos()
    {
        // ____________________________________________________________________________________________
        // -----------------------------------hop Gizmo------------------------------------------------
        // ____________________________________________________________________________________________

        Gizmos.color = Color.green;
        Vector3 size = MakeGroundcheckSize();
        Gizmos.DrawWireCube(groundCheck.position, size);

        // ____________________________________________________________________________________________
        // -----------------------------------slå Gizmo------------------------------------------------
        // ____________________________________________________________________________________________

         Gizmos.DrawWireCube(slag.position, size);
         Gizmos.

    }

    private Vector3 MakeGroundcheckSize() => new Vector3(0.45f, groundRadius);

}
