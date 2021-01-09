using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTriggerPlayer : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject ZombieA;
    public BoxCollider2D PlayerTrigger;
    private Animator animZombie;

    public SpawnGround script;
    public GameObject Placescript;
    void Start()
    {
        Placescript = GameObject.Find("kucha");
        script = Placescript.GetComponent<SpawnGround>();
        ZombieA = script.newZombie;
        animZombie = ZombieA.GetComponent<Animator>();
        Trigger = GameObject.Find("PlayerTarget");
        PlayerTrigger = Trigger.GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D  (Collider2D other)
    {
    if(other.gameObject.tag == "Player")
        {
           
           animZombie.SetBool("IsAttack", false);
           animZombie.SetBool("IsAttack2", false);
           animZombie.SetBool("IsAttack3", false);
        }
    }
}
