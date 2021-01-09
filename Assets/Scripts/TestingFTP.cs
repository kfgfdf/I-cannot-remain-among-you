using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class TestingFTP : MonoBehaviour
{
    public GameObject mus;
    private AudioSource aSrc;
    private AudioClip a1;
    void Start()
    {

        aSrc = mus.GetComponent<AudioSource>();
        StartCoroutine(LoadAudioFromServer("file:///C:/Users/kfgfdf/Desktop/Danger%20Snow%20-%20Dan%20Henig.mp3", AudioType.OGGVORBIS));

    }
    IEnumerator LoadAudioFromServer(string url, AudioType audioType)
{
    Debug.Log("Startyem");   
    var request = UnityWebRequestMultimedia.GetAudioClip(url, audioType);

    yield return request.SendWebRequest();

    if (!request.isHttpError && !request.isNetworkError)
    {
    	a1 = DownloadHandlerAudioClip.GetContent(request);    
    }
    else
    {
    	Debug.LogErrorFormat("error request [{0}, {1}]", url, request.error);

        a1 = null;
    }
    Debug.Log("nnnn");
    request.Dispose();
}

    void Update()
    {
        aSrc.clip=a1;
        aSrc.Play();
    }
}


