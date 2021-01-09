using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTriggers : MonoBehaviour
{
    public Rigidbody2D DestrTrigs;
    void Start()
    {
        DestrTrigs = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D (Collider2D other)
    {
    if(other.gameObject.tag == "GroundTrigger")
        {

          
             Destroy(other.gameObject);
            
            
        }
    if(other.gameObject.tag == "Score")
        {

          
             Destroy(other.gameObject);
            
            
        }
    }
    
}
