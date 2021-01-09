using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasEndurance : MonoBehaviour
{
    public Text txtButBuyEndurance;
    void Start()
    {
       
    }
    void Update()
    {
      if(PlayerPrefs.GetFloat("endurance") == 1f)
        {
            txtButBuyEndurance.text = "Максимальный запас!";
        }
    }
}
