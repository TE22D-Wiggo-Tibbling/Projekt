using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Mathematics;
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

  // [SerializeField]
  // float dash = 1.0f;
  // [SerializeField]
  // int dashtimeNeed = 10;
  // int dashTimeGone = 1000000;
  // [SerializeField]
  // float dashCooldown;




  [SerializeField]
  Transform groundCheck;

  [SerializeField]
  LayerMask groundLayer;

  [SerializeField]
  float groundRadius = 0.4f;


  [SerializeField]
  GameObject slagPrefab;

  [SerializeField]
  GameObject slå;


float rotation;


  static public Vector3 mouse = new Vector3();

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




    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    if (worldPosition.x > GameObject.FindGameObjectWithTag("Body").transform.position.x)
    {
      mouse = new Vector2(Input.mousePosition.x, 0);
    }
    else
    {
      mouse = new Vector2(-Input.mousePosition.x, 0);
    }

  if(mouse.x<0){
    rotation=180;
  }
  else
  {
    rotation=0;
  }

    // if (Input.GetKeyDown(KeyCode.Mouse0) && mouse.x > 0 && isGrounded)
    // {

    //   Instantiate(slagPrefab, slå.transform.position + mouse.normalized, Quaternion.identity);
    // }
    if (Input.GetKeyDown(KeyCode.Mouse0)  && isGrounded)
    {

      Instantiate(slagPrefab, slå.transform.position + mouse.normalized, Quaternion.Euler(0, rotation, 0));
    }



    if (Input.GetKeyDown(KeyCode.Mouse1) && isGrounded)
    {
      GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = Color.green;
    }
    if (Input.GetKeyUp(KeyCode.Mouse1) || !isGrounded)
    {

      GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = Color.white;
    }


    //     Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //     Vector2 mouse;
    //     if (worldPosition.x > GameObject.FindGameObjectWithTag("Body").transform.position.x)
    //     {
    //       mouse = new Vector2(Input.mousePosition.x, 0);
    //     }
    //     else
    //     {
    //       mouse = new Vector2(-Input.mousePosition.x, 0);
    //     }


    //     dashTimeGone++;
    //     if (Input.GetKeyDown(KeyCode.Mouse0) && isGrounded == true&& dashTimeGone>dashtimeNeed+dashCooldown)
    //     {
    //       dashTimeGone = 0;
    //       transform.Translate(mouse.normalized * dash);
    //       GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = new Color(0, 204, 102);
    //     }
    //     if (dashTimeGone == dashtimeNeed)
    //     {
    // GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = new Color(255,255,255);
    //       transform.Translate(-mouse.normalized * dash);
    //     }

    // Debug.Log(Input.mousePosition);
    //     // Debug.Log(mouse.normalized);
    // Debug.Log(this.gameObject.transform.position.x);
    // Debug.Log(worldPosition);
    // Debug.Log(isGrounded);
  }









  // }

  public Vector3 MakeGroundcheckSize() => new Vector3(groundRadius, groundRadius);



}
