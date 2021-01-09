using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroy : MonoBehaviour
{
    public Rigidbody2D DestrBG;
    void Start()
    {
        DestrBG = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
    if(other.gameObject.tag == "BackGround")
        {
            Destroy(other.gameObject);
        }
    }
}
