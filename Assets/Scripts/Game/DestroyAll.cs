using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour
{
    public GameObject Destroyer;
    public Rigidbody2D Destr;
    
    void Start()
    {
        Destr = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D (Collider2D other)
    {
    if(other.gameObject.tag == "Ground")
        {

          
             Destroy(other.gameObject);
            
            
        }
    if(other.gameObject.tag == "Terminal1")
        {

          
             Destroy(other.gameObject);
            
            
        }
    }
}
