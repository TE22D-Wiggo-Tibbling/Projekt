using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Health : MonoBehaviour
{

    [SerializeField]
    int MaxHp = 10;
    public static int Hp;

    public static bool alive;

    [SerializeField]
    Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Hp = MaxHp;


        healthBar.maxValue = MaxHp;

        healthBar.value = Hp;

    }

    // Update is called once per frame
    void Update()
    {

        healthBar.value = Hp;

        if (this.gameObject.transform.position.y < -7)
        {
            Health.Hp = 0;
            takingDamage.DödsAnledning = "tappa för mycket ballans";
        }

        if (Hp == 0)
        {
            SceneManager.LoadScene(2);

        }
    }




}
