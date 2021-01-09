using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie1Move : MonoBehaviour
{
    public Rigidbody2D Zombie1;
    public Transform punch1;
    public float punch1Radius;
    public SpawnGround script;
    public TargetPlayerZombie1 scriptTrig;
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

    private MovingPlayer scriptPlayer;
    void Start()
    {
        Placescript = GameObject.Find("kucha");
        script = Placescript.GetComponent<SpawnGround>();
        ZombieA = script.newZombie;
        Trigger = ZombieA.transform.Find("PlayerTarget").gameObject;
        scriptTrig = Trigger.GetComponent<TargetPlayerZombie1>();
        Zombie1 = GetComponent<Rigidbody2D>();

        scriptPlayer = Placescript.GetComponent<MovingPlayer>();
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        isPlayer = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsPlayer);
        isTrap = Physics2D.OverlapCircle(feetPosTrap.position, checkRadius, whatIsTrap);
        if(scriptTrig.MoveToPlayer != 0 && isPlayer == false)
        Zombie1.velocity = new Vector2(-scriptTrig.MoveToPlayer - 0.6f, Zombie1.velocity.y);
        if(isGrounded == true || isTrap == true)
        Zombie1.velocity = Vector2.up * 5;
    }
    public void Attack()
    {
        if(scriptPlayer.IsBoost == true)
        {
        EnemyMeeleAttack.Action(punch1.position, punch1Radius, 10, 0.5f, false);
        }
        else
        {
        EnemyMeeleAttack.Action(punch1.position, punch1Radius, 10, 1, false);
        }
        
    }
}
