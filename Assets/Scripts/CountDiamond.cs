using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDiamond : MonoBehaviour
{
    public Text txt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = PlayerPrefs.GetInt("coundDiamond").ToString();
    }
}
