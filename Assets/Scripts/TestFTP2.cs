using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class TestFTP2 : MonoBehaviour
{
    IEnumerator LoadAudioFromServer(string url, AudioType audioType, Action<AudioClip> response)
{
    var request = UnityWebRequestMultimedia.GetAudioClip(url, audioType);

    yield return request.SendWebRequest();

    if (!request.isHttpError && !request.isNetworkError)
    {
    	response(DownloadHandlerAudioClip.GetContent(request));    
    }
    else
    {
    	Debug.LogErrorFormat("error request [{0}, {1}]", url, request.error);

        response(null);
    }

    request.Dispose();
}
}
