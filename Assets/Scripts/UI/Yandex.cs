using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Agava.YandexGames;

public class Yandex : MonoBehaviour
{
    private IEnumerator Start()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
         yield break;
#endif
      yield return YandexGamesSdk.Initialize();

       DontDestroyOnLoad(this.gameObject);
       SceneManager.LoadScene(1);
    }
    
}
