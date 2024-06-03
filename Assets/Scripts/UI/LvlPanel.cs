using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlPanel : MonoBehaviour
{
    [SerializeField] private GameObject[] imageStars;
    [SerializeField] private int _lvl;

    private void Start()
    {
        for (int i = 0; i < imageStars.Length; i++)
            imageStars[i].SetActive(false);

        int value = PlayerPrefs.GetInt(SaveStars.StarSaveKeyPrefix + _lvl);
        CountingStarsOnLvl(value);
    }

    private void CountingStarsOnLvl(int countStars)
    {

        for (int i = 0; i < countStars; i++)
        {
            imageStars[i].SetActive(true);
        }
    }
    public void LoadScene()
    {

        SceneManager.LoadScene(_lvl);
    }
}
