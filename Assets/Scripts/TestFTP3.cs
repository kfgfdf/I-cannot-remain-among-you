using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class TestFTP3 : MonoBehaviour
{
    //public bool disposeDownloadHandlerOnDispose = false;
    //public bool disposeDownloadHandlerOnDispose;

    public AudioSource audioSource;
    public string URL;
    //public Text txtToday;
    public Text txtYesterday;
    public GameObject[] objs1;
    public GameObject BGMusic; 
    public static float musicVolume; 
    public Slider VolValue; //Слайдер если нужна регулировка
    public Text ProgressDownload;
    public GameObject PlayButn;

    void Awake() 
    {
        objs1 = GameObject.FindGameObjectsWithTag("Sound"); //не забываем задать тег Sound для префаба с музыкой
        if (objs1.Length == 0)
            {
                BGMusic = Instantiate(BGMusic); //создаем объект из префаба
                BGMusic.name = "BGMusic";  //необязательно, просто внешний вид улучшает:)
                DontDestroyOnLoad(BGMusic.gameObject); //Ответ на Ваш вопрос
            } else {
                BGMusic = GameObject.Find("BGMusic"); //обращаемся к объекту, если он уже существует.
            }
            if (!PlayerPrefs.HasKey("MusicVol")) 
            {
           musicVolume = 0.7f; //тут громкость по умолчанию
           }  
            else
            {
                musicVolume = PlayerPrefs.GetFloat("MusicVol"); //сохраненная громкость
                VolValue.value = PlayerPrefs.GetFloat("MusicVol"); //меняем значение слайдера на сохраненную громкость
            }
    }
    public void Start()
    {
        audioSource = BGMusic.GetComponent<AudioSource>();
    }

    public void GetBtnToday()
    {
       // URL = txtToday.text;
       // StartCoroutine(GetData());
    }

     public void GetBtnYesterday()
    {
        URL = txtYesterday.text;
        StartCoroutine(GetData());
    }

   public IEnumerator GetData()
    {

        

        //прогресс загрузки
        //DownloadProgress

        // Создаем загрузчик аудио
        DownloadHandlerAudioClip downloadHandler = new DownloadHandlerAudioClip("", AudioType.OGGVORBIS);
        //Делаем загрузку аудио потоковой
        downloadHandler.streamAudio = true;
        UnityWebRequest request = new UnityWebRequest(URL, "GET", downloadHandler, null);

        request.disposeDownloadHandlerOnDispose = false;

        // Начинаем загрузку аудио
        request.SendWebRequest();
        AudioClip audioClip = null;
        //в цикле проверяем завершенность загрузки
        while (audioClip == null )
        {
           
            try
            {
                //request.downloadHandler = CacheableDownloadHandler;
                //пытаемся получить скаченное аудио
                audioClip = DownloadHandlerAudioClip.GetContent(request);
                
                //request.downloadHandler = new DownloadHandlerBuffer(); 
                //audioClip = DownloadHandlerBuffer.GetData(request);
               // audioClip = DownloadHandlerBuffer.GetContent(request);
            }
            catch (Exception e) {
                //возвращает ошибку, что еще не скачано
                Debug.Log("Exception: " + e.Message);
            }
             //проверяю количество загруженых байтов( то есть, из них можна что-то вытянуть, но как?)
             //Debug.Log("Загружено байтов: "+ request.downloadedBytes );
             ProgressDownload.text = "Скачено: " + request.downloadedBytes.ToString() + " байтов";
             PlayButn.SetActive(false);
            yield return 0f;
        }

        // кладу загруженное аудио в аудиосоурс
        audioSource.clip = audioClip;
        audioSource.Play();
        ProgressDownload.text = "";
        PlayButn.SetActive(true);
        //disposeDownloadHandlerOnDispose = false;
        yield return 0;
    }
    public void Update()
   {
      // URL = txt.text;
       audioSource.volume = musicVolume;
   }

    public void SetVolume(float vol)
    {
        //VolValue.value = musicVolume;
        musicVolume = vol;
        PlayerPrefs.SetFloat("MusicVol", vol); //сохраняем громкость
    }
}

