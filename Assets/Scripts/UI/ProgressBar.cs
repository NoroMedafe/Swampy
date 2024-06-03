using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private Transform _currentPosition;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _endPoint.position.y * -1;
        _slider.value = 0;
    }

    private void Update()
    {
        if (_currentPosition.position.y<0)
        {
            _slider.value = _currentPosition.position.y * -1;
        }
    }
}
