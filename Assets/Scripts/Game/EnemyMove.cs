using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform punch1;
    public float punch1Radius;
    private MovingPlayer scriptPlayer;
    private GameObject Player;
    public bool GuardBoost;

    void Start()
    {
        Player = GameObject.Find("kucha");
        scriptPlayer = Player.GetComponent<MovingPlayer>();
    }
    void Update()
    {
        GuardBoost = scriptPlayer.IsBoost;
    }
    public void Attack()
    {
        if(GuardBoost == true)
        {
        EnemyMeeleAttack.Action(punch1.position, punch1Radius, 10, 1f, false);
        }
        else
        {
            EnemyMeeleAttack.Action(punch1.position, punch1Radius, 10, 2f, false);
        }
        
    }
}
