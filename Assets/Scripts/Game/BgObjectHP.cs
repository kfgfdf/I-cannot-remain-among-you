using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgObjectHP : MonoBehaviour
{
    public float HP = 100;
    private MovingPlayer scriptPlayer;
    private GameObject Player;
    //public bool IsBoostGuard;

    void Start()
    {
        Player = GameObject.Find("kucha");
        scriptPlayer = Player.GetComponent<MovingPlayer>();
    }
    void Update()
    {
        if(HP <= 0)
        {  
            Destroy(gameObject); 
            scriptPlayer.IsBoost = false;
            scriptPlayer.IsBoost = true;
            scriptPlayer.timeRemaining = 15;
        }
        if(HP == 50)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
        }
    }
}
