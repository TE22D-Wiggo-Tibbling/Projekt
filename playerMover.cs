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


  [SerializeField]
  GameObject flyttare;


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



if(!block.blok){

    float moveX = Input.GetAxisRaw("Horizontal");

    Vector2 movementX = new Vector2(moveX, 0);

    transform.Translate(movementX * speed * Time.deltaTime);
}
    













    // Debug.Log(Input.mousePosition);
    //     // Debug.Log(mouse.normalized);
    // Debug.Log(this.gameObject.transform.position.x);
    // Debug.Log(worldPosition);
    // Debug.Log(isGrounded);
  }









  // }

  public Vector3 MakeGroundcheckSize() => new Vector3(groundRadius, groundRadius);



}
