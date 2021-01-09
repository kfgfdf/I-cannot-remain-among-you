using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2Move : MonoBehaviour
{
    public Rigidbody2D Zombie2;
    public Transform punch1;
    public float punch1Radius;
    public SpawnGround script;
    public TargetPlayerZombie2 scriptTrig;
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
        scriptTrig = Trigger.GetComponent<TargetPlayerZombie2>();
        Zombie2 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        isPlayer = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsPlayer);
        isTrap = Physics2D.OverlapCircle(feetPosTrap.position, checkRadius, whatIsTrap);
        if(scriptTrig.MoveToPlayer != 0 && isPlayer == false)
        Zombie2.velocity = new Vector2(-scriptTrig.MoveToPlayer - 0.3f, Zombie2.velocity.y);
        if(isGrounded == true || isTrap == true)
        Zombie2.velocity = Vector2.up * 5;
    }
    public void Attack()
    {
        EnemyMeeleAttack.Action(punch1.position, punch1Radius, 10, 1, false);
        
    }
}
