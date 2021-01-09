using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class AdMobStart : MonoBehaviour
{
    private BannerView bannerView;
    void Start()
    {
        //string appId = "ca-app-pub-8727171403153065~3322215062";
        //MobileAds.Initialize(appId);
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }
    
    private void RequestBanner()
    {
        //string adUnitId = "ca-app-pub-8727171403153065/9301300059";
        string adUnitId = "ca-app-pub-3940256099942544/6300978111"; //testovieID
        
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        if(PlayerPrefs.GetInt("DonationNoAds") == 1)
        {

        }
        else
        {
        GameObject go = GameObject.Find("Destroyer");
            if(go != null)
            {
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);
            }
            else
            {
                bannerView.Destroy();
            }
        }
    }
}
