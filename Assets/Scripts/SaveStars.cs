using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveStars : MonoBehaviour
{
    public const string StarSaveKeyPrefix = "LvlStars ";
    public void RecordStars(int countStars)
    {
        string key = StarSaveKeyPrefix + SceneManager.GetActiveScene().buildIndex.ToString();
        int countSaveStars = PlayerPrefs.GetInt(key);
        if (countSaveStars < countStars)
        {
            PlayerPrefs.SetInt(key, countStars);
           
        }
    }
}
