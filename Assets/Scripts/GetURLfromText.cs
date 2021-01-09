using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class GetURLfromText : MonoBehaviour
{
    public string urlka;
    public string everday;
    public Text txt;
    public int Swit;
    void Start()
    {
        txt.ToString();
        StartCoroutine(LoadTextFromServer(urlka,""));
    }
    IEnumerator LoadTextFromServer(string url, string response)
{
    var request = UnityWebRequest.Get(url);

    yield return request.SendWebRequest();

    if (!request.isHttpError && !request.isNetworkError)
    {
        response = request.downloadHandler.text;        
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
