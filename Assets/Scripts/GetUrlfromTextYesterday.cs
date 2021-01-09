using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class GetUrlfromTextYesterday : MonoBehaviour
{
    public string urlka;
    //public string everday;
    public Text txt;
    //public int Swit;
    public GameObject ButtonDownload;
    public GameObject ButtonStart;
    public GameObject ButtonShop;
    public GameObject Slider;
    public GameObject TextNetwork;
    public GameObject TextNameGame;
    //public GameObject AnimPlayer;
    void Start()
    {
        txt.ToString();
        StartCoroutine(LoadTextFromServer(urlka,""));
    }
    IEnumerator LoadTextFromServer(string url, string response)
{
    while(true)
        {
    var request = UnityWebRequest.Get(url);

    yield return request.SendWebRequest();

    if (!request.isHttpError && !request.isNetworkError)
    {
        response = request.downloadHandler.text;    
        ButtonDownload.SetActive(true);
        ButtonStart.SetActive(true);
        ButtonShop.SetActive(true);
        Slider.SetActive(true);
        TextNameGame.SetActive(true);
        //AnimPlayer.SetActive(true);
        TextNetwork.SetActive(false);
    }
    else
    {
    	Debug.LogErrorFormat("error request [{0}, {1}]", url, request.error);
       
        response = null;
    }
    txt.text = response.ToString();
    request.Dispose();
        }
}
}
