using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    [SerializeField] private int _requiredAmountWater;

    private int _currentCountWater = 0;
    public event Action WaterAbundance;

    private bool _isStarted = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Fluid>())
        {
            _currentCountWater++;
        }
        if (_currentCountWater >= _requiredAmountWater && _isStarted == false)
        {
            WaterAbundance?.Invoke();
            _isStarted = true;
        }
    }
}
