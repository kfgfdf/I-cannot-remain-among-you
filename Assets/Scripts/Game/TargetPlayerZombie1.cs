using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayerZombie1 : MonoBehaviour
{
     public GameObject Trigger;
    public GameObject ZombieA;
    public BoxCollider2D PlayerTrigger;
    private Animator animZombie;
    public SpawnGround script;
    public GameObject Placescript;

    public float MoveToPlayer;

    void Start()
    {
        Placescript = GameObject.Find("kucha");
        script = Placescript.GetComponent<SpawnGround>();
        ZombieA = script.newZombie;
        animZombie = ZombieA.GetComponent<Animator>();
        Trigger = GameObject.Find("PlayerTarget");
        PlayerTrigger = Trigger.GetComponent<BoxCollider2D>();

        MoveToPlayer = 0;
    }
    void Update()
    {
    }
    void OnTriggerStay2D (Collider2D other)
    {
    if(other.gameObject.tag == "Player")
        {
           animZombie.SetBool("IsAttack", true);  
           MoveToPlayer = 1f;
        }
    }
}
