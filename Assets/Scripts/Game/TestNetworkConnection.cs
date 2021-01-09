using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class TestNetworkConnection : MonoBehaviour
{
    public string urlka;
    public GameObject TestNetworkCanvas;
    public GameObject MainCanvas;
    private bool Refresher;
    void Start()
    {
        StartCoroutine(LoadTextFromServer(urlka,""));
    }
    IEnumerator LoadTextFromServer(string url, string response)
{
    while(true)
        {
            if(Refresher == false)
            {
                yield return new WaitForSeconds(15);
            }
            else 
            {
                yield return new WaitForSeconds(0);
            }
    var request = UnityWebRequest.Get(url);

    yield return request.SendWebRequest();

    if (!request.isHttpError && !request.isNetworkError)
    {   
        TestNetworkCanvas.SetActive(false);
        MainCanvas.SetActive(true);
    }
    else
    {
    	TestNetworkCanvas.SetActive(true);
        MainCanvas.SetActive(false);
        response = null;
    }
    request.Dispose();
        }
   
}

    public void Refresh()
    {
        StartCoroutine(Refreshing());
    }

IEnumerator Refreshing()
    {
        Refresher = true;
        yield return new WaitForSeconds(2);
        Refresher = false;
    }
}
