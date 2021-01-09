using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalBoost : MonoBehaviour
{
    public bool BoostTerminal1; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetPressedTermina1()
    {
        BoostTerminal1 = true;
        StartCoroutine(DISELECTBostTerminal1());
    }
    IEnumerator DISELECTBostTerminal1()
    {
        yield return new WaitForSeconds(5);
        BoostTerminal1 = false;
        
    }
}
