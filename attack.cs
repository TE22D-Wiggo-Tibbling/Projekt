using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    [SerializeField]
    float timeExist = 10;


    // Start is called before the first frame update
    void Start()
    {
            Destroy(this.gameObject,timeExist);

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }



}
