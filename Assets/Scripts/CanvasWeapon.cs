using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasWeapon : MonoBehaviour
{
    public Text txtButSkin1;
    public Text txtButSkin2;
    public Text txtButSkin3;
    void Start()
    {
        //if (!PlayerPrefs.HasKey("Weapon")) 
        //{
          //  PlayerPrefs.SetInt("Weapon", 1);
        //}
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("Weapon") == 1)
        {
            txtButSkin1.text = "Выбрано";
            if(PlayerPrefs.GetInt("WeaponSkin2Buying") == 1)
            txtButSkin2.text = "Куплено!";
            if(PlayerPrefs.GetInt("WeaponSkin3Buying") == 1)
            txtButSkin3.text = "Куплено!";
        }
        if(PlayerPrefs.GetInt("Weapon") == 2)
        {
            txtButSkin2.text = "Выбрано";
            if(PlayerPrefs.GetInt("WeaponSkin1Buying") == 1)
            txtButSkin1.text = "Куплено!";
            if(PlayerPrefs.GetInt("WeaponSkin3Buying") == 1)
            txtButSkin3.text = "Куплено!";
        }
        if(PlayerPrefs.GetInt("Weapon") == 3)
        {
            txtButSkin3.text = "Выбрано";
            if(PlayerPrefs.GetInt("WeaponSkin1Buying") == 1)
            txtButSkin1.text = "Куплено!";
            if(PlayerPrefs.GetInt("WeaponSkin2Buying") == 1)
            txtButSkin2.text = "Куплено!";
        }
    }
}
