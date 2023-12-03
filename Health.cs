using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField]
    int MaxHp = 10;
    public static int Hp;

    public static bool alive;

    // Start is called before the first frame update
    void Start()
    {
        Hp = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp < 0)
        {
            alive = false;

        }
    }
}
