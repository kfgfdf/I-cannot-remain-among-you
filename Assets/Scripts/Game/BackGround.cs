using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    public Sprite day;
    public Sprite nigth;
    public SpriteRenderer Background;
    void Start()
    {
        InvokeRepeating("SwithDtoN",0,10);
    }

    public void SwithDtoN()
    {
        if(Background.sprite = day)
        {
            Background.sprite = nigth;
        }
        if(Background.sprite = nigth)
        {
            Background.sprite = day;
        }
    }
    void Update()
    {
        Background.sprite = nigth;
        Background.sprite = day;
    }
}
