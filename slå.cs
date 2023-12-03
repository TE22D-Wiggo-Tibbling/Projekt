using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class slå : MonoBehaviour
{

  [SerializeField]
  Transform slag;

  float rotation;


  [SerializeField]
  GameObject groundCheck;

  [SerializeField]
  LayerMask groundLayer;




  [SerializeField]
  GameObject slagPrefab;

  static public Vector3 mouse = new Vector3();

  [SerializeField]
  GameObject sla;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    if (worldPosition.x > GameObject.FindGameObjectWithTag("Body").transform.position.x)
    {
      mouse = new Vector2(Input.mousePosition.x, 0);
    }
    else
    {
      mouse = new Vector2(-Input.mousePosition.x, 0);
    }

    if (mouse.x < 0)
    {
      rotation = 180;
    }
    else
    {
      rotation = 0;
    }







    if (Input.GetKeyDown(KeyCode.Mouse0) && jumper.isGrounded)
    {

      Instantiate(slagPrefab, sla.transform.position + mouse.normalized, Quaternion.Euler(0, rotation, 0));
    }

  }

  void OnDrawGizmos()
  {


    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector3 mouse = new Vector3();
    if (worldPosition.x > GameObject.FindGameObjectWithTag("Body").transform.position.x)
    {
      mouse = new Vector2(Input.mousePosition.x, 0);
    }
    else
    {
      mouse = new Vector2(-Input.mousePosition.x, 0);
    }
    Vector3 hit = new Vector3(slag.position.x + mouse.normalized.x, slag.position.y);
    Gizmos.color = Color.green;




  }



}
