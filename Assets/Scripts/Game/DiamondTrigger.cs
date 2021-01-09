using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondTrigger : MonoBehaviour
{
    //public GameObject Diamond;
    //private BoxCollider2D DiamondCollid;
    public Rigidbody2D Player;
    private GameObject PlayerGO;
    public Text txt;
    public int CountDiamond;
    public int NewCountDiamond;
    private MovingPlayer scriptMovePlayer;
    private PlayerHP scriptPlayerHP;

    

    void Start()
    {
      // PlayerPrefs.SetInt("coundDiamond", 2354);
        PlayerGO = GameObject.Find("kucha");
        Player = PlayerGO.GetComponent<Rigidbody2D>();
        scriptMovePlayer = PlayerGO.GetComponent<MovingPlayer>();
        scriptPlayerHP = PlayerGO.GetComponent<PlayerHP>();
        //Diamond = GameObject.Find("Diamond");
        //Box
        if (!PlayerPrefs.HasKey("coundDiamond"))
        { PlayerPrefs.SetInt("coundDiamond", 0); }

        CountDiamond = PlayerPrefs.GetInt("coundDiamond");
        NewCountDiamond = CountDiamond;
    }
    void Update()
    {
        txt.text = NewCountDiamond.ToString();
        
    }

     void OnTriggerEnter2D (Collider2D other)
    {
     if(other.gameObject.tag == "Diamond")
        {
            NewCountDiamond++;
            
            PlayerPrefs.SetInt("coundDiamond", NewCountDiamond);
            
            Destroy(other.gameObject);
        }
     if(other.gameObject.tag == "BottleEndurance")
        {
            
            scriptMovePlayer.StaminVolumeFloat = scriptMovePlayer.StaminVolumeFloat + 0.05f;
            Destroy(other.gameObject);
        }
     if(other.gameObject.tag == "OneHP")
        {
            
            scriptPlayerHP.HP = scriptPlayerHP.HP + 1;
            Destroy(other.gameObject);
        }
        
    }
}
