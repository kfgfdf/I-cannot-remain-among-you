using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float HP = 100;
    public GameObject Diamond;
    private GameObject newDiamond;
    private int ZombieNumber;
    private int RNDZombie2;
    private int RNDZombie3;
    private int RNDDonation;

    public GameObject BottleEndurance;
    private GameObject newBottleEndurance;

    public GameObject OneHP;
    private GameObject newOneHP;

    void Start()
    {

        if (!PlayerPrefs.HasKey("NumberZombie")) 
        {
        ZombieNumber = 1;
        }
        else
        {
            ZombieNumber = PlayerPrefs.GetInt("NumberZombie");
        }
        //Diamond = Prefab.Find("kucha");

    }
    void Update()
    {
        RNDZombie2 = Random.Range(1, 7);
        RNDZombie3 = Random.Range(1, 10);
        RNDDonation = Random.Range(1, 11);
        if(HP <= 0)
        {
            if(ZombieNumber == 1)
            {
            newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
            Destroy(gameObject); 
            }
            if(ZombieNumber == 2)
            {
                if(RNDZombie2 == 1 || RNDZombie2 == 2 || RNDZombie2 == 3)
                {
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x + 0.1f,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }
                if(RNDZombie2 == 4 || RNDZombie2 == 5 || RNDZombie2 == 6)
                {
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }
            Destroy(gameObject); 
            }
            if(ZombieNumber == 3)
            {
                if(RNDZombie3 == 1 || RNDZombie3 == 2 || RNDZombie3 == 3)
                {
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x + 0.1f,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }
                if(RNDZombie3 == 4 || RNDZombie3 == 5 || RNDZombie3 == 6)
                {
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }
                if(RNDZombie3 == 7 || RNDZombie3 == 8 || RNDZombie3 == 9)
                {
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x + 0.1f,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                    newDiamond = Instantiate(Diamond, new Vector3(gameObject.transform.position.x - 0.1f,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }
            Destroy(gameObject); 
            }

            if(PlayerPrefs.GetInt("DonationEndurance") == 1)
                {
                    if(RNDDonation == 1 || RNDDonation == 2)
                    newBottleEndurance = Instantiate(BottleEndurance, new Vector3(gameObject.transform.position.x + 0.25f,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }
            if(PlayerPrefs.GetInt("DonationHP") == 1)
                {
                    if(RNDDonation == 3 || RNDDonation == 4)
                    newOneHP = Instantiate(OneHP, new Vector3(gameObject.transform.position.x - 0.18f,gameObject.transform.position.y -0.3f, 0), Quaternion.identity)as GameObject;
                }

        }
    }
}
