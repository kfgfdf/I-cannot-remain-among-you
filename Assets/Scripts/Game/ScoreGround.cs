using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGround : MonoBehaviour
{
    public int ScoreMeters;
    public Text ScoreMetersText;
    void Start()
    {
      
    }

    void Update()
    {
        ScoreMetersText.text = ScoreMeters.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Score")
        {
            ScoreMeters++;
        }
    }
    void OnTriggerStay2D (Collider2D other)
    {
      if(other.gameObject.tag == "Score")
      {
        Destroy(other.gameObject);
      }
    }
}
