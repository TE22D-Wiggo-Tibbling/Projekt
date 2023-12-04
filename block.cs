using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{

    public static bool blok;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = Color.green;
            blok = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            blok = false;
            GameObject.FindGameObjectWithTag("Body").GetComponent<Renderer>().material.color = Color.white;
        }




    }



}
