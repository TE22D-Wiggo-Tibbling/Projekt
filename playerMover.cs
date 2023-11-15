using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class playerMovement : MonoBehaviour
{

  [SerializeField]
  float speed = 3;



  [SerializeField]
  GameObject body;


  //  Vector3 mousePos; = Input.mousePosition;




  [SerializeField]
  Transform slag;

  // [SerializeField]
  // Vector3 dash = new Vector3(1,0,0);

  [SerializeField]
  float dash = 1.0f;
  [SerializeField]
  int dashtimeNeed = 10;
  int dashTimeGone = 1000000;



  [SerializeField]
  Transform groundCheck;

  [SerializeField]
  LayerMask groundLayer;

  [SerializeField]
  float groundRadius = 0.4f;


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Vector2 mouse = new Vector2(Input.mousePosition.x,0);




    float moveX = Input.GetAxisRaw("Horizontal");

    Vector2 movementX = new Vector2(moveX, 0);

    transform.Translate(movementX * speed * Time.deltaTime);



    Vector3 size = MakeGroundcheckSize();
    bool isGrounded = Physics2D.OverlapBox(groundCheck.position, size, 0, groundLayer);





    Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    Vector2 mouse;
    if (worldPosition.x > GameObject.FindGameObjectWithTag("Body").transform.position.x)
    {
      mouse = new Vector2(Input.mousePosition.x, 0);
    }
    else
    {
      mouse = new Vector2(-Input.mousePosition.x, 0);
    }


    dashTimeGone++;
    if (Input.GetKeyDown(KeyCode.Mouse0) && isGrounded == true)
    {
      dashTimeGone = 0;
      transform.Translate(mouse.normalized * dash);

    }
    if (dashTimeGone == dashtimeNeed)
    {

      transform.Translate(-mouse.normalized * dash);
    }

    // Debug.Log(Input.mousePosition);
    //     // Debug.Log(mouse.normalized);
    // Debug.Log(this.gameObject.transform.position.x);
    // Debug.Log(worldPosition);
    // Debug.Log(isGrounded);
  }






  // void OnDrawGizmos()
  // {
  //     // ____________________________________________________________________________________________
  //     // -----------------------------------hop Gizmo------------------------------------------------
  //     // ____________________________________________________________________________________________

  //     Gizmos.color = Color.green;
  //     Vector3 size = MakeGroundcheckSize();
  //     Gizmos.DrawWireCube(groundCheck.position, size);

  //     // ____________________________________________________________________________________________
  //     // -----------------------------------slå Gizmo------------------------------------------------
  //     // ____________________________________________________________________________________________

  //      Gizmos.DrawWireCube(slag.position, size);


  // }

  public Vector3 MakeGroundcheckSize() => new Vector3(groundRadius, groundRadius);



}
