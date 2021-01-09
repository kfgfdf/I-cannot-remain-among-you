using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject ShopCanvas;
    public GameObject BuyEnemyCanvas;
    public GameObject EnemyError;
    public GameObject EnemyBuyingPanel;
    public GameObject HPCanvas;
    public GameObject HPError;
    public GameObject HPBuyingPanel;
    public GameObject EnduranceCanvas;
    public GameObject EnduranceError;
    public GameObject EnduranceBuyingPanel;
    public GameObject WeaponCanvas;
    public GameObject WeaponError;
    public GameObject WeaponBuyingPanel;
    public GameObject BackGroundCanvas;
    public GameObject BackGroundError;
    public GameObject BackGroundBuyingPanel;

    public GameObject ListShopBuyEnemy;
    void Start()
    {
        //PlayerPrefs.SetInt("coundDiamond", 300);
    }

    void Update()
    {
        
    }
    public void GoToShopCanvas()
    {
        MainCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
    public void GoToMainCanvas()
    {
        MainCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
    }
    public void GoToBuyEnemyCanvas()
    {
        BuyEnemyCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
    }
    public void BuyEnemy1()
    {
     if(PlayerPrefs.GetInt("NumberZombie") == 1)
     {

     }
     else
     {
            PlayerPrefs.SetInt("NumberZombie", 1); 
     }
    }
    
    public void BuyEnemy2()
    {
     if(PlayerPrefs.GetInt("NumberZombie") == 2)
     {
         
     }
     else
     {
         if(PlayerPrefs.GetInt("ZombieSkin2Buying") == 1)
         {
         PlayerPrefs.SetInt("NumberZombie", 2); 
         }
         else
         {
        if(PlayerPrefs.GetInt("coundDiamond") >= 200)
        {
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 200);
            PlayerPrefs.SetInt("ZombieSkin2Buying", 1);
            PlayerPrefs.SetInt("NumberZombie", 2); 
            EnemyBuyingPane();
        }
        else
        {
            EnemyErrorPanel();
        }
         }
     }
    }
    public void BuyEnemy3()
    {
     if(PlayerPrefs.GetInt("NumberZombie") == 3)
     {
         
     }
     else
     {
         if(PlayerPrefs.GetInt("ZombieSkin3Buying") == 1)
         {
         PlayerPrefs.SetInt("NumberZombie", 3); 
         }
         else
         {
        if(PlayerPrefs.GetInt("coundDiamond") >= 400)
        {
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 400);
            PlayerPrefs.SetInt("ZombieSkin3Buying", 1);
            PlayerPrefs.SetInt("NumberZombie", 3); 
            EnemyBuyingPane();
        }
        else
        {
            EnemyErrorPanel();
        }
         }
     }
    }
    public void EnemyBuyingPane()
    {
        EnemyBuyingPanel.SetActive(true);
    }
    public void CloseEnemyBuyingPane()
    {
        EnemyBuyingPanel.SetActive(false);
    }
    public void EnemyErrorPanel()
    {
        EnemyError.SetActive(true);
    }
    public void CloseEnemyErrorPanel()
    {
        EnemyError.SetActive(false);
    }
    public void BuyEnemyCanvasControlRight()
    {
        if(ListShopBuyEnemy.transform.position.x >= -12)
        {
            ListShopBuyEnemy.transform.position = new Vector2(ListShopBuyEnemy.transform.position.x - 4f, ListShopBuyEnemy.transform.position.y);
        }
    }
    public void BuyEnemyCanvasControlLeft()
    {
        if(ListShopBuyEnemy.transform.position.x <= 0)
        {
            ListShopBuyEnemy.transform.position = new Vector2(ListShopBuyEnemy.transform.position.x + 4f, ListShopBuyEnemy.transform.position.y);
        }
    }
    public void GoToShopCanvasWithBuyEnemyCanvas()
    {
        BuyEnemyCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
    //HPSHOP
    public void GoToBuyHPCanvas()
    {
        HPCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
    }
    public void BuyHP()
    {
     if(PlayerPrefs.GetFloat("HP") == 20)
     {

     }
     else
    {
        if(PlayerPrefs.GetInt("coundDiamond") >= 150)
        {
            PlayerPrefs.SetFloat("HP", PlayerPrefs.GetFloat("HP") + 1); 
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 150);
            HPBuyingPanerl();
        }
        else{HPErrorPanel();}
    }
    }
    public void BuyHPSkin1()
    {
        if(PlayerPrefs.GetInt("coundDiamond") >= 50 && PlayerPrefs.GetInt("HPSkin") != 1)
        {
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 50);
            PlayerPrefs.SetInt("HPSkin", 1);
            HPBuyingPanerl();
        }
        else{HPErrorPanel();}
    }
    public void HPBuyingPanerl()
    {
        HPBuyingPanel.SetActive(true);
    }
    public void CloseHPBuyingPanerl()
    {
        HPBuyingPanel.SetActive(false);
    }
    public void HPErrorPanel()
    {
        HPError.SetActive(true);
    }
    public void HPCloseErrorPanel()
    {
        HPError.SetActive(false);
    }
    public void GoToShioWithHPCanvas()
    {
        HPCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
    //EnduranceShop
    public void GoToBuyEnduranceCanvas()
    {
        EnduranceCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
    }
    public void BuyEndurance()
    {
     if(PlayerPrefs.GetFloat("endurance") == 1f)
     {

     }
     else
     {
        if(PlayerPrefs.GetInt("coundDiamond") >= 120)
        {
            PlayerPrefs.SetFloat("endurance",  PlayerPrefs.GetFloat("endurance") + 0.05f);
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 120);
            EnduranceBuyingPane();
        }
        else{EnduranceErrorPanel();}
     }
    }
    public void EnduranceBuyingPane()
    {
        EnduranceBuyingPanel.SetActive(true);
    }
    public void CloseEnduranceBuyingPane()
    {
        EnduranceBuyingPanel.SetActive(false);
    }
    public void EnduranceErrorPanel()
    {
        EnduranceError.SetActive(true);
    }
    public void CloseEnduranceErrorPanel()
    {
        EnduranceError.SetActive(false);
    }
    public void GoToShopWithEnduranceCanvas()
    {
        EnduranceCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
    //weaponSHOP
    public void GoToBuyWeaponCanvas()
    {
        WeaponCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
    }
    public void BuyWeapon1()
    {
     if(PlayerPrefs.GetInt("WeaponSkin1Buying") == 1)
     {
         PlayerPrefs.SetInt("Weapon", 1);
     }
     else
     {
        if(PlayerPrefs.GetInt("coundDiamond") >= 100 && PlayerPrefs.GetInt("Weapon") != 1)
        {
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 100);
            PlayerPrefs.SetInt("WeaponSkin1Buying", 1);
            PlayerPrefs.SetInt("Weapon", 1);
            WeaponBuyingPane();
        }
        else{WeaponErrorPanel();}
     }
    }
    public void BuyWeapon2()
    {
     if(PlayerPrefs.GetInt("WeaponSkin2Buying") == 1)
     {
         PlayerPrefs.SetInt("Weapon", 2);
     }
     else
     {
        if(PlayerPrefs.GetInt("coundDiamond") >= 200 && PlayerPrefs.GetInt("Weapon") != 2)
        {
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 200);
            PlayerPrefs.SetInt("WeaponSkin2Buying", 1);
            PlayerPrefs.SetInt("Weapon", 2);
            WeaponBuyingPane();
        }
        else{WeaponErrorPanel();}
     }
    }
    public void BuyWeapon3()
    {
     if(PlayerPrefs.GetInt("WeaponSkin3Buying") == 1)
     {
         PlayerPrefs.SetInt("Weapon", 3);
     }
     else
     {
        if(PlayerPrefs.GetInt("coundDiamond") >= 300 && PlayerPrefs.GetInt("Weapon") != 3)
        {
            PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 300);
            PlayerPrefs.SetInt("WeaponSkin3Buying", 1);
            PlayerPrefs.SetInt("Weapon", 3);
            WeaponBuyingPane();
        }
        else{WeaponErrorPanel();}
     }
    }
    public void WeaponBuyingPane()
    {
        WeaponBuyingPanel.SetActive(true);
    }
    public void CloseWeaponBuyingPane()
    {
        WeaponBuyingPanel.SetActive(false);
    }
    public void WeaponErrorPanel()
    {
        WeaponError.SetActive(true);
    }
    public void CloseWeaponErrorPanel()
    {
        WeaponError.SetActive(false);
    }
    public void GoToShopWithWeaponCanvas()
    {
        WeaponCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
    //BackGroundSHOP
    public void GoToBuyBackGroundCanvas()
    {
        BackGroundCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
    }
    public void BuyBackGround1()
    {
        
            PlayerPrefs.SetInt("BackGroundFon", 1);
           // BackGroundBuyingPane();
    }
    public void BuyBackGround2()
    {
        if(PlayerPrefs.GetInt("BackGroundFon2Buying") == 1) 
        {
            PlayerPrefs.SetInt("BackGroundFon", 2);
        }
        else
        {
            if(PlayerPrefs.GetInt("coundDiamond") >= 300)
            {
             PlayerPrefs.SetInt("BackGroundFon", 2);
             PlayerPrefs.SetInt("BackGroundFon2Buying", 1);
              PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 300);
              BackGroundBuyingPane();
             }
            
            else{BackGroundErrorPanel();}
        }
    }
    public void BuyBackGround3()
    {
        if(PlayerPrefs.GetInt("BackGroundFon3Buying") == 1) 
        {
            PlayerPrefs.SetInt("BackGroundFon", 3);
        }
        else
        {
            if(PlayerPrefs.GetInt("coundDiamond") >= 400)
            {
             PlayerPrefs.SetInt("BackGroundFon", 3);
             PlayerPrefs.SetInt("BackGroundFon3Buying", 1);
              PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") - 400);
              BackGroundBuyingPane();
             }
            
            else{BackGroundErrorPanel();}
        }
    }
    public void BackGroundBuyingPane()
    {
        BackGroundBuyingPanel.SetActive(true);
    }
    public void CloseBackGroundBuyingPane()
    {
        BackGroundBuyingPanel.SetActive(false);
    }
    public void BackGroundErrorPanel()
    {
        BackGroundError.SetActive(true);
    }
    public void CloseBackGroundErrorPanel()
    {
        BackGroundError.SetActive(false);
    }
    public void GoToShopWithBackGroundCanvas()
    {
        BackGroundCanvas.SetActive(false);
        ShopCanvas.SetActive(true);
    }
}
