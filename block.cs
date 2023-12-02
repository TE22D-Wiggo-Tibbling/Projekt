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
        if(Input.GetKeyUp(KeyCode.Mouse1)){

        GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = Color.white;
        }
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = Color.green;
        }
      
        
            
        
    }


    
}
