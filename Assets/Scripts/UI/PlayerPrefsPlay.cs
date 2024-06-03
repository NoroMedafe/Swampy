using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerPrefsPlay : MonoBehaviour
{
    [SerializeField] private int _countLvls = 10;

    private int _failedLvl = 2;

    private void Awake()
    {
        for (int i = 2; i < _countLvls + 2; i++)
        {
            if (PlayerPrefs.GetInt(SaveStars.StarSaveKeyPrefix + i) == 0)
            {
                _failedLvl =  i;
                break;
            }
        }
    }

    public void StartFailedLvl()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_failedLvl);
    }
}
