using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        }
        // else{
        //                 GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = new Color(255, 255, 255);
      
        // }
        
            
        
    }


    
}
