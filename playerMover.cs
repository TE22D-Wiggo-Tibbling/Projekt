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


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Vector2 mouse = new Vector2(Input.mousePosition.x,0);



    if (!block.blok)
    {

      float moveX = Input.GetAxisRaw("Horizontal");

      Vector2 movementX = new Vector2(moveX, 0);

      transform.Translate(movementX * speed * Time.deltaTime);
    }









  }









  // }





}
