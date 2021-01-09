using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonationContoll : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void DonationNoAds()
    {
        PlayerPrefs.SetInt("DonationNoAds", 1);
    }
    public void DonationDropHp()
    {
        PlayerPrefs.SetInt("DonationHP", 1);
    }
    public void DonationDropEndurance()
    {
        PlayerPrefs.SetInt("DonationEndurance", 1);
    }
}
