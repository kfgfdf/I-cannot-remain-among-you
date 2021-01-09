using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public float Speed;
    public MovingPlayer script;
    public Rigidbody2D BG;
    public GameObject Movingpla;
   // public GameObject Cam;
    //public GameObject Bgshka;
    void Start()
    {
        BG = GetComponent<Rigidbody2D>();
        Movingpla = GameObject.Find("kucha");
        script = Movingpla.GetComponent<MovingPlayer>();
       // BG.transform.position = new Vector3( 0, Cam.transform.position.y, 10);
        
    }

    // Update is called once per frame
    void Update()
    {
        //BG.postion.y = Cam.transfrom.postion.y;
        if(script.MoveInput >= 0.25f )
       {
       BG.velocity = Vector2.left * Speed;
       }
      // else if(script.MoveInput <= -0.25f)
       //{
         //  BG.velocity = -Vector2.left * Speed;
      // }
       else
       {
           BG.Sleep();
       }
       if(script.VerticalMove > 0f && script.MoveInput <= 0.25f)
       {
           BG.Sleep();
       }
    }
}
