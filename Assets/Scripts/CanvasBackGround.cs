using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBackGround : MonoBehaviour
{
    public Text txtButSkin1;
    public Text txtButSkin2;
    public Text txtButSkin3;
    void Start()
    {
        if (!PlayerPrefs.HasKey("BackGroundFon")) 
        {
            PlayerPrefs.SetInt("BackGroundFon", 1);
        }
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("BackGroundFon") == 1)
        {
            txtButSkin1.text = "Выбран";
            if(PlayerPrefs.GetInt("BackGroundFon2Buying") == 1){
            txtButSkin2.text = "Куплено!";}
            else{
            txtButSkin2.text = "Купить за 300 алмазов";}

            if(PlayerPrefs.GetInt("BackGroundFon3Buying") == 1){
            txtButSkin3.text = "Куплено!";}
            else{
            txtButSkin3.text = "Купить за 400 алмазов";}
        }
        if(PlayerPrefs.GetInt("BackGroundFon") == 2)
        {
            txtButSkin1.text = "Куплено!";
            txtButSkin2.text = "Выбран";
            if(PlayerPrefs.GetInt("BackGroundFon3Buying") == 1){
            txtButSkin3.text = "Куплено!";}
            else{
            txtButSkin3.text = "Купить за 400 алмазов";}
        }
        if(PlayerPrefs.GetInt("BackGroundFon") == 3)
        {
            txtButSkin1.text = "Куплено!";
            txtButSkin3.text = "Выбран";
            if(PlayerPrefs.GetInt("BackGroundFon2Buying") == 1){
            txtButSkin2.text = "Куплено!";}
            else{
            txtButSkin2.text = "Купить за 300 алмазов";}
        }
    }
}
