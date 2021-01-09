using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie3Move : MonoBehaviour
{
    public Rigidbody2D Zombie3;
    public Transform punch1;
    public float punch1Radius;
    public SpawnGround script;
    public TargetPlayerZombie3 scriptTrig;
    public GameObject Trigger;
    public GameObject Placescript;
    public GameObject ZombieA;

    public Transform feetPos;
    public bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool isPlayer;
    public LayerMask whatIsPlayer;
    public bool isTrap;
    public Transform feetPosTrap;
    public LayerMask whatIsTrap;
    void Start()
    {
        Placescript = GameObject.Find("kucha");
        script = Placescript.GetComponent<SpawnGround>();
        ZombieA = script.newZombie;
        Trigger = ZombieA.transform.Find("PlayerTarget").gameObject;
        scriptTrig = Trigger.GetComponent<TargetPlayerZombie3>();
        Zombie3 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        isPlayer = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsPlayer);
        isTrap = Physics2D.OverlapCircle(feetPosTrap.position, checkRadius, whatIsTrap);


        if(scriptTrig.MoveToPlayer != 0 && isPlayer == false)
        Zombie3.velocity = new Vector2(-scriptTrig.MoveToPlayer, Zombie3.velocity.y);
        if(isGrounded == true || isTrap == true)
        Zombie3.velocity = Vector2.up * 5;
    }
    public void Attack()
    {
        EnemyMeeleAttack.Action(punch1.position, punch1Radius, 10, 1, false);
        
    }
}
