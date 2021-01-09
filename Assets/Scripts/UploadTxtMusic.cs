using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class UploadTxtMusic : MonoBehaviour
{
    public InputField inputtext;
    public Text txt;
    public GameObject inputuser;
    public GameObject startupload;
    public GameObject uplod;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GetUploadtxt()
    {
        inputuser.SetActive(true);
        uplod.SetActive(true);
        startupload.SetActive(false);

    }
    public void Uploadtxt()
    {
        inputuser.SetActive(false);
        uplod.SetActive(false);
        startupload.SetActive(true);
        txt.text = "Music title loaded!";
        
    }
}
