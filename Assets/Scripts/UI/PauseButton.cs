using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _clipper;
    public void GetPause()
    {
        _menu.SetActive(true);
        _clipper.SetActive(false);
        Time.timeScale = 0;

    }
    public void GetUnPause()
    {
        _menu.SetActive(false);
        _clipper.SetActive(true);
        Time.timeScale = 1;

    }
}
