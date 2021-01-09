using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;

public class NetworkEnter : MonoBehaviour
{
    //public string URL;
    public GameObject DontNet;

     private const bool allowCarrierDataNetwork = false;
    private const string pingAddress = "8.8.8.8"; // Google Public DNS server
    private const float waitingTime = 2.0f;

    private Ping ping;
    private float pingStartTime;

    public void Start()
    {
        InternetAvailable();

       // bool internetPossiblyAvailable;
        //switch (Application.internetReachability)
        //{
          //  case NetworkReachability.ReachableViaLocalAreaNetwork:
            //    internetPossiblyAvailable = true;
              //  break;
            //case NetworkReachability.ReachableViaCarrierDataNetwork:
              //  internetPossiblyAvailable = allowCarrierDataNetwork;
           //   break;
        //    default:
            //    internetPossiblyAvailable = false;
           //     break;
     //   }
      //  if (!internetPossiblyAvailable)
      //  {
       //     InternetIsNotAvailable();
       //     return;
       // }
       // ping = new Ping(pingAddress);
      //  pingStartTime = Time.time;
    }

    public void Update()
    {
       // if (ping != null)
      //  {
       //     bool stopCheck = true;
      //      if (ping.isDone)
       //     {
      //          if (ping.time >= 0)
        //            InternetAvailable();
       //         else
        //            InternetIsNotAvailable();
        //    }
      //      else if (Time.time - pingStartTime < waitingTime)
      //          stopCheck = false;
     //       else
      //          InternetIsNotAvailable();
      //      if (stopCheck)
      //          ping = null;
     //   }
    }

    private void InternetIsNotAvailable()
    {
        Debug.Log("No Internet :(");
        DontNet.SetActive(true);
    }

    private void InternetAvailable()
    {
        Debug.Log("Internet is available! ;)");
        SceneManager.LoadScene(1);
    }
}

