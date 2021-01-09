using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHP : MonoBehaviour
{
    public Text txtButBuyHP;
    void Start()
    {
        
    }
    void Update()
    {
        if(PlayerPrefs.GetFloat("HP") == 20)
        txtButBuyHP.text = "Максимальный запас!";
    }
}
