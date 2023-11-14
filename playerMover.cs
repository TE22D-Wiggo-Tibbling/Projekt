using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


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

  float dash = 1.0f;

  int dashtimeNeed = 10;
  int dashTimeGone = 1000000;



  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Vector2 mouse = new Vector2(Input.mousePosition.x,0);
    Vector2 mouse;
    if (Input.mousePosition.x/100 > this.gameObject.transform.position.x)
    {
      mouse = new Vector2(Input.mousePosition.x, 0);
    }
    else
    {
      mouse = new Vector2(-Input.mousePosition.x, 0);
    }


    Debug.Log(Input.mousePosition);
    // Debug.Log(mouse.normalized);
Debug.Log(this.gameObject.transform.position.x);

    float moveX = Input.GetAxisRaw("Horizontal");

    Vector2 movementX = new Vector2(moveX, 0);

    transform.Translate(movementX * speed * Time.deltaTime);

    dashTimeGone++;
    if (Input.GetKeyDown(KeyCode.Q))
    {
      dashTimeGone = 0;
      transform.Translate(mouse.normalized * dash);

    }
    if (dashTimeGone == dashtimeNeed)
    {

      transform.Translate(-mouse.normalized * dash);
    }
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





}
