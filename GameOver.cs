using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static Points instance;
    public Text scoreText;

    int score = 0;


    private void Awake()
    {
        // instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text =takingDamage.DödsAnledning;
    }

 

    // Update is called once per frame
    void Update()
    {

    }
}
