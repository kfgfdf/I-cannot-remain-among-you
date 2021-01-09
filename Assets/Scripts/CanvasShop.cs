using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;

public class CanvasShop : MonoBehaviour
{
    private RewardedAd rewardedAd;
    public GameObject RewardAdBut;
    public void Start()
    {
        string adUnitId;
        adUnitId = "ca-app-pub-3940256099942544/5224354917";
        this.rewardedAd = new RewardedAd(adUnitId);

        
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

        //if (this.rewardedAd.IsLoaded()) 
       // {
       //     RewardAdBut.SetActive(true);
       // }
      //  else
       // {
      //      RewardAdBut.SetActive(false);
       // }
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") + 60);
    }

    public void UserChoseToWatchAd()
    {
     if (this.rewardedAd.IsLoaded()) 
        {
        this.rewardedAd.Show();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
