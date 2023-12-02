using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    [SerializeField]
    float timeExist=10;
    
    [SerializeField]
    float timeGone=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeGone+=Time.deltaTime;
        if (timeGone>timeExist)
        {
            Destroy(this.gameObject);
        }
    }

      
    
}
