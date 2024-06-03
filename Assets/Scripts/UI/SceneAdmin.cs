using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneAdmin : MonoBehaviour
{
    [SerializeField] private Text _textLevel;

    private void Start()
    {
       _textLevel.text = "Level " + (SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }
  
}
