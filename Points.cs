using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;
    public Text scoreText;

    int score = 0;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "KILLS:" + score.ToString();
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "KILLS:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
