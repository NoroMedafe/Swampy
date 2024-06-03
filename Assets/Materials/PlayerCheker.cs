using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityStandardAssets.Water;

[RequireComponent(typeof (CircleCollider2D))]
public class PlayerCheker : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private GameObject _endMenu;

    private CircleCollider2D circleCollider;
    private int _countWater=0;
    private int _timeForLose = 3;
    private Coroutine coroutine;
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    private  void Update()
    {
        if (_countWater <5)
        {
            if (coroutine == null)
            {
                coroutine = StartCoroutine(Timer());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Water>())
        {
            _countWater++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Water>())
        {
            _countWater--;
        }
    }
    private IEnumerator Timer()
    {
        float time = _timeForLose;


        while (time < _timeForLose)
        {
            time -= Time.deltaTime;
            int a= (int)(time * 100 / 100);
            _text.text = a.ToString();
            yield return null;
        }
        coroutine = null;
        _endMenu.SetActive(true);
    }
  
}
