using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayer : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject ZombieA;
    public BoxCollider2D PlayerTrigger;
   // public bool BoolTrigger;
    //private Rigidbody2D ZombieTriggerPlayer;
    private Animator animZombie;

    private int ZombieNumber;
    public SpawnGround script;
    public GameObject Placescript;

    void Start()
    {
        Placescript = GameObject.Find("kucha");
        script = Placescript.GetComponent<SpawnGround>();
        ZombieA = script.newZombie;
        //ZombieA = GameObject.Find("Zombie(Clone)");
        animZombie = ZombieA.GetComponent<Animator>();
        Trigger = GameObject.Find("PlayerTarget");
       // animZombie = GetComponent<Animator>();
        //ZombieTriggerPlayer = GetComponent<Rigidbody2D>();
        PlayerTrigger = Trigger.GetComponent<BoxCollider2D>();
       // BoolTrigger = Trigger.GetComponent<BoxCollider2D>().isTrigger;

        
       if (!PlayerPrefs.HasKey("NumberZombie")) 
        {
        ZombieNumber = 1;
        }
        else
        {
            ZombieNumber = PlayerPrefs.GetInt("NumberZombie");
        }
    }

    void Update()
    {
        //RNDAnim = Random.Range(1,3);
    }
    void OnTriggerStay2D (Collider2D other)
    {
    if(other.gameObject.tag == "Player")
        {
           if(ZombieNumber == 1)
          // animZombie.Play("ZombieAttack");
           animZombie.SetBool("IsAttack", true);

           if(ZombieNumber == 2)
           //animZombie.Play("ZombieAttack2");
           animZombie.SetBool("IsAttack2", true);

           if(ZombieNumber == 3)
           //animZombie.Play("ZombieAttack2");
           animZombie.SetBool("IsAttack3", true);
             
        }
    }
}
