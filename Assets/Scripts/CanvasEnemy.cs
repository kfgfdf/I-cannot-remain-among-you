using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasEnemy : MonoBehaviour
{
    public Text txtButSkin1;
    public Text txtButSkin2;
    public Text txtButSkin3;
    void Start()
    {
        if (!PlayerPrefs.HasKey("NumberZombie")) 
        {
            PlayerPrefs.SetInt("NumberZombie", 1);
        }
        
    }

    
    void Update()
    {
        if(PlayerPrefs.GetInt("NumberZombie") == 1)
        {
            txtButSkin1.text = "Выбрано";
            if(PlayerPrefs.GetInt("ZombieSkin2Buying") == 1)
            txtButSkin2.text = "Куплено!";
            if(PlayerPrefs.GetInt("ZombieSkin3Buying") == 1)
            txtButSkin3.text = "Куплено!";
        }
        if(PlayerPrefs.GetInt("NumberZombie") == 2)
        {
            txtButSkin2.text = "Выбрано";
            txtButSkin1.text = "Куплено!";
            if(PlayerPrefs.GetInt("ZombieSkin3Buying") == 1)
            txtButSkin3.text = "Куплено!";
        }
        if(PlayerPrefs.GetInt("NumberZombie") == 3)
        {
            txtButSkin3.text = "Выбрано";
            txtButSkin1.text = "Куплено!";
            if(PlayerPrefs.GetInt("ZombieSkin2Buying") == 1)
            txtButSkin2.text = "Куплено!";
        }
    }
}
