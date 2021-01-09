using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPlayerHazmat : MonoBehaviour
{
    private int Color;
    private GameObject Body;
    public Sprite spriteDefolt;
    public Sprite spriteDefoltfffff;

    public Sprite White;
    public Sprite Black;
    public Sprite Red;
    public Sprite LightGreen;
    public Sprite Green;
    public Sprite Blue;
    public Sprite LightBlue;
    public Sprite Brown;
    public Sprite Purple;
    public Sprite Pink;
    public Sprite Orange;
    public Sprite Yellow;
    void Start()
    {
             PlayerPrefs.SetInt("ColorHazmatPlayer", 7);
        Body = GameObject.FindWithTag("Body");

        
        Color = PlayerPrefs.GetInt("ColorHazmatPlayer");
        if(Color == 1)
        spriteDefolt = White;
        if(Color == 2)
        spriteDefolt = Black;
        if(Color == 3)
        spriteDefolt = Red;
        if(Color == 4)
        spriteDefolt = LightGreen;
        if(Color == 5)
        spriteDefolt = Green;
        if(Color == 6)
        spriteDefolt = Blue;
        if(Color == 7)
        spriteDefolt = LightBlue;
        if(Color == 8)
        spriteDefolt = Brown;
        if(Color == 9)
        spriteDefolt = Purple;
        if(Color == 10)
        spriteDefolt = Pink;
        if(Color == 11)
        spriteDefolt = Orange;
        if(Color == 12)
        spriteDefolt = Yellow;

        
    }

    // Update is called once per frame
    void Update()
    {
      // Body.GetComponent<SpriteRenderer>().sprite = spriteDefolt;
      spriteDefoltfffff = Body.GetComponent<SpriteRenderer>().sprite;
    }
}
