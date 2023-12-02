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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
         Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         Vector3 mouse=new Vector3();
    if (worldPosition.x > GameObject.FindGameObjectWithTag("Body").transform.position.x)
    {
      mouse = new Vector2(Input.mousePosition.x, 0);
    }
    else
    {
      mouse = new Vector2(-Input.mousePosition.x, 0);
    }
    Vector3 hit = new Vector3(slag.position.x+mouse.normalized.x,slag.position.y);
        Gizmos.color = Color.green;
        Vector3 size = MakeGroundcheckSize();
        Gizmos.DrawWireCube(hit, size);
       
    }

    private Vector3 MakeGroundcheckSize() => new Vector3(1f, 1f);

}
