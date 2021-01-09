using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovingPlayer : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rb;
    public Joystick joystick;
    public float MoveInput;
    public float VerticalMove;
    public float JumpForce;
    private bool faceRight = true;
    public Transform feetPos;
    public bool isGrounded;
    public bool isAttack = false;
    public float chechRadius;
    public LayerMask whatIsGround;
    public Animator animPlayer;


    public Transform punch1;
    public float punch1Radius;
    

    private bool punch;
    private int rndAnimAttack;
    

    public Slider stamin;
    public Text ProcentEndurance;
    private static float StaminVolume; 
    public float StaminVolumeFloat; 
    //public GameObject DeadMenu;
    public GameObject StaminaIsNull;


    public bool IsBoost;
    public GameObject EffectBoostGuard;
    public Text TimerBoost;


public float timeRemaining = 0;

    private int ColorHazmat;

    void Start()
    {
        StaminVolumeFloat = StaminVolume;
        //PlayerPrefs.SetFloat("Stamina", 0.3f);
        animPlayer = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
       // stamin.value = PlayerPrefs.GetFloat("Stamina");


       TimerBoost.text = "";
       ColorHazmat = PlayerPrefs.GetInt("ColorHazmatPlayer") - 1;
        
    }

    void Awake()
    {
        if (!PlayerPrefs.HasKey("endurance")) 
            {
                StaminVolume = 0.1f; //тут громкость по умолчанию
                PlayerPrefs.SetFloat("endurance", StaminVolume);
                StaminVolume = PlayerPrefs.GetFloat("endurance"); 
                stamin.value = PlayerPrefs.GetFloat("endurance"); 
            }  
            else
            {
                StaminVolume = PlayerPrefs.GetFloat("endurance"); //сохраненная громкость
                stamin.value = PlayerPrefs.GetFloat("endurance"); //меняем значение слайдера на сохраненную громкость
            }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rndAnimAttack = Random.Range(1, 4);
        punch = animPlayer.GetBool("isPunch"); 

        MoveInput = joystick.Horizontal;
        //rb.velocity = new Vector2(MoveInput * Speed, rb.velocity.y);
        rb.transform.Translate(rb.transform.right * MoveInput * Speed * Time.deltaTime);
        if(MoveInput == 0 && isGrounded == false)
        {
           // animPlayer.SetBool("IsRunning", false);
            //animPlayer.Play("idle");
        }
        else if(MoveInput != 0 && isGrounded == true && isAttack == false && joystick.Vertical <= 0.62f)
        {
            //animPlayer.SetBool("IsRunning", true);
            animPlayer.Play(ColorHazmat + "PlayerRun");
        }
        else if(MoveInput == 0 && joystick.Vertical <= 0.62f && isGrounded == true)
        {
            //анимация ИДЛ!!!!
            if(!isAttack)
            animPlayer.Play(ColorHazmat + "PlayerIdle");
        }
        if(faceRight == false && MoveInput > 0)
        {
            Flip();
        }
        else if(faceRight == true && MoveInput < 0)
        {
            Flip();
        }

        isGrounded = Physics2D.OverlapCircle(feetPos.position, chechRadius, whatIsGround);

        VerticalMove = joystick.Vertical;
        if(isGrounded == true && VerticalMove >= 0.62f)
        {
            rb.velocity = Vector2.up * JumpForce;
            //animPlayer.SetBool("isJump", true);
            animPlayer.Play(ColorHazmat + "PlayerJump");
        }
        //if(VerticalMove >= 0.5f)
        else if(VerticalMove >= 0.62f && MoveInput >= 0.7f)
        {
            //анимация прыжка вперед
            animPlayer.Play(ColorHazmat + "PlayerJump");
            //animPlayer.SetBool("isJump", false);
        }
       
        
    }
    void Update()
    {   
        
        if(IsBoost == true)
        {
            TimerBoost.text = "00:" + Mathf.FloorToInt(timeRemaining).ToString("00");
            StartCoroutine(Boost1Off());
            EffectBoostGuard.SetActive(true);
            //StartCoroutine(EffectBoostChange());
            if (timeRemaining > 0)
            {
            timeRemaining -= Time.deltaTime;
            } 
        }



        stamin.value = StaminVolumeFloat;
        ProcentEndurance.text = Mathf.Floor(StaminVolumeFloat * 100) + "%";
        if(stamin.value <= 0.01f)
        {
            StaminaIsNull.SetActive(true);
        }
        else
        {
            StaminaIsNull.SetActive(false);
        }
    }
        IEnumerator Boost1Off()
    {
        yield return new WaitForSeconds(0);
       // yield return new WaitForSeconds(15);
       if (timeRemaining <= 0)
       {
           TimerBoost.text = "";
        IsBoost = false;  
        EffectBoostGuard.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
        EffectBoostGuard.SetActive(false);     
       } 
       
    }
        IEnumerator EffectBoostChange()
        {
             yield return new WaitForSeconds(0.5f);
            EffectBoostGuard.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
        }
    
    void Flip()
    {
        faceRight = !faceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void PUNCHCLICK()
    {
     
        if(StaminVolumeFloat >= 0.01f && !isAttack)
        {
            //isAttack = true;
            StaminVolumeFloat = StaminVolumeFloat - 0.01f;
            //SetNewVolume();
            

           // animPlayer.enabled = false;
           
            isAttack = true;

           // animPlayer.Play("PunchSword" + rndAnimAttack);
            //animPlayer.Play("PlayerPunch1");

            if(MoveInput >= 0.5f && VerticalMove <= 0.62f)
            {
                animPlayer.Play("PlayerPunchRun1");
            }
            else
            {
                animPlayer.Play(ColorHazmat + "PlayerPunch1");
            }
            
            
     
            StartCoroutine(PUNCHCLICKDISELECT());
           
            //animPlayer.SetBool("isPunch", true);
        }
	    //MeeleAttack.Action(punch1.position, punch1Radius, 9, 12, false);
        //Invoke("Zhopka",2);
            
        
    }
    IEnumerator PUNCHCLICKDISELECT()
    {
        yield return new WaitForSeconds(1);
        isAttack = false;
        //    animPlayer.SetBool("isPunch", false);
        
    }

    public void Attack()
    {
        MeeleAttack.Action(punch1.position, punch1Radius, 9, 100, false);

        MeeleAttackBGObjects.Action(punch1.position, punch1Radius, 12, 50, false);
        
    }

    public void SetVolume(float stfloat, float st)
    {
        StaminVolume = st;
        StaminVolumeFloat = stfloat;
       //st = 0.1f;
        PlayerPrefs.SetFloat("endurance", st);
    }
      void OnDestroy()
    {
        
        //DeadMenu.SetActive(true);
        //Time.timeScale = 0;
    }
}
