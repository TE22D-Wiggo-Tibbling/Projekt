using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (Hp == 0)
        {
            SceneManager.LoadScene(1);

        }
          if(this.gameObject.transform.position.y<-7){
      Health.Hp=0;
      takingDamage.DödsAnledning="tappa för mycket ballans";
    }
    }

    
   
    
}
