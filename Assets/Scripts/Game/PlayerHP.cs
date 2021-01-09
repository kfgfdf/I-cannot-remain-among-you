using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class PlayerHP : MonoBehaviour
{
   public float HP;
   private float StartHP;
   private float CurentHP;
   public GameObject DeadMenu;
   public GameObject PauseMenu;
   public GameObject  joystick;
   public GameObject  AttackBut;
   public GameObject  PauseButton;


   public Text DeadMenuTextScore;


   public Sprite HerLeftOriginal;
   public Sprite HerLeftBlack;

   private GameObject Player;
   private Sprite Head;
   private Color coloHead;

   public GameObject HeadKucha;
   //public Sprite[] sprites = new Sprite[2];

   public ScoreGround script;


   //private GameObject CountDiamonds;
    public Text TextCoundDiaminds;
    public Text TextCoundScoreRecord;
   // public DiamondTrigger scriptDiamonds;
    private int StartDiamonds;
    private int CurrentDiamonds;

    public GameObject StaminaIsNull;

    private InterstitialAd interstitial;

    public Slider HPslider;
    public Text HPText;


    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestInterstitial();
        //PlayerPrefs.SetFloat("HP", 20);
        StartDiamonds = PlayerPrefs.GetInt("coundDiamond");
         Player = GameObject.Find("Body");
         Head = Player.GetComponent<SpriteRenderer>().sprite;
         coloHead = Player.GetComponent<SpriteRenderer>().color;

        // CountDiamonds = GameObject.Find("TextCoundDiaminds");
        //TextCoundDiaminds = CountDiamonds.GetComponent<Text>();
         
        if (!PlayerPrefs.HasKey("HP")) 
            {
                HP = 2f;
            }
        else
        {
            HP = PlayerPrefs.GetFloat("HP"); 
        }
        StartHP = HP;
        CurentHP = HP;

        
    }
    private void RequestInterstitial()
{
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";

     // Initialize an InterstitialAd.
    this.interstitial = new InterstitialAd(adUnitId);

    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the interstitial with the request.
    this.interstitial.LoadAd(request);
}
    void Update()
    {
        

        HeadKucha.GetComponent<SpriteRenderer>().color = coloHead;

        CurentHP = StartHP - HP;
        if(CurentHP != 0)
        {
            coloHead = new Color(255, 0, 0, 255);
           Invoke("NormColor", 0.2f);
        }

        HPslider.value = HP;
        HPText.text = HP * 5 + "%";
        
        CurrentDiamonds = PlayerPrefs.GetInt("coundDiamond") - StartDiamonds;
        if(HP <= 0)
        {
            Destroy(gameObject);
            StaminaIsNull.SetActive(false);
            DeadMenu.SetActive(true);
            Time.timeScale = 0;
            DeadMenuTextScore.text = script.ScoreMeters.ToString();
            
            TextCoundDiaminds.text = CurrentDiamonds.ToString();

            if(PlayerPrefs.GetInt("countMeters") < script.ScoreMeters)
            {
                PlayerPrefs.SetInt("countMeters", script.ScoreMeters);
            }
            TextCoundScoreRecord.text = PlayerPrefs.GetInt("countMeters").ToString();

            if(PlayerPrefs.GetInt("DonationNoAds") == 1)
            {

            }
            else
            {
            if (this.interstitial.IsLoaded()) 
                {
                this.interstitial.Show();
                }
            }

        }
    }
    public void NormColor()
    {
        coloHead = new Color(255, 255, 255, 255);
        CurentHP = HP;
        StartHP = HP;
    }
    public void PauseMenuOpen()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        joystick.SetActive(false);
        AttackBut.SetActive(false);
        PauseButton.SetActive(false);

    }
    public void PauseMenuClose()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        joystick.SetActive(true);
        AttackBut.SetActive(true);
        PauseButton.SetActive(true);
    }
}
