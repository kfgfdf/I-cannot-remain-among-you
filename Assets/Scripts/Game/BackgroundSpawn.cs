using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    public GameObject Cam;
    public Rigidbody2D BG;
    public GameObject Background;
    public GameObject Background2;
    public GameObject Background3;
    private GameObject newBackground;
    public GameObject DestroyerBg;
    public GameObject Spawnbg;
    public float Speed;
    public MovingPlayer script;
    void Start()
    {
        if(!PlayerPrefs.HasKey("BackGroundFon"))
        PlayerPrefs.SetInt("BackGroundFon", 1);

        Cam = GameObject.Find("Main Camera");
        
        if(PlayerPrefs.GetInt("BackGroundFon") == 1)
        newBackground = Instantiate(Background, new Vector3(Cam.transform.position.x +6f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;
        if(PlayerPrefs.GetInt("BackGroundFon") == 2)
        newBackground = Instantiate(Background2, new Vector3(Cam.transform.position.x +6f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;
        if(PlayerPrefs.GetInt("BackGroundFon") == 3)
        newBackground = Instantiate(Background3, new Vector3(Cam.transform.position.x +6f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;
       //BG = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        DestroyerBg.transform.position = new Vector3(Cam.transform.position.x - 46.7f, 0, 0);
        Spawnbg.transform.position = new Vector3(Cam.transform.position.x - 24.055f, 0, 0);

       // if(script.MoveInput > 0)
       // {
        //    Background.transform.position = new Vector3(Background.transform.position.x * Speed, Cam.transform.position.y -3, 10);
       // }
       //BG.velocity = new Vector2(-Speed * script.MoveInput, BG.velocity.y);
       
    }

    void OnTriggerEnter2D (Collider2D other)
    {
    if(other.gameObject.tag == "BackGround")
        {
            if(PlayerPrefs.GetInt("BackGroundFon") == 1 || !PlayerPrefs.HasKey("BackGroundFon"))
            newBackground = Instantiate(Background, new Vector3(Cam.transform.position.x +27.78f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;
            if(PlayerPrefs.GetInt("BackGroundFon") == 2)
            newBackground = Instantiate(Background2, new Vector3(Cam.transform.position.x +27.78f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;
            if(PlayerPrefs.GetInt("BackGroundFon") == 3)
            newBackground = Instantiate(Background3, new Vector3(Cam.transform.position.x +27.78f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;

         //newBackground = Instantiate(Background, new Vector3(Cam.transform.position.x +27.75502f,Cam.transform.position.y -2.999998f, 10), Quaternion.identity, Cam.transform)as GameObject;
          //  Destroy(other.gameObject);
        }
    }
}
