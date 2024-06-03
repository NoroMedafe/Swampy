using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DropSpawner : MonoBehaviour
{
    [SerializeField] private int _waterCount = 40;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _dropPrefab;

    private List<GameObject> _waterPull;
    private float _average;
    private bool _isWater = true;
    public float Average => _average;
    private void Start()
    {
        _waterPull = new List<GameObject>(_waterCount);
        if (_dropPrefab.GetComponent<Fluid>())
        {
            for (int i = 0; i < _waterCount; i++)
            {
                _waterPull.Add(Instantiate(_dropPrefab, transform.position + new Vector3(Random.Range(0, 1f), Random.Range(0, 1f)), Quaternion.identity));
            }
        }
        else
        {
            for (int i = 0; i < _waterCount; i++)
            {
                Instantiate(_dropPrefab, transform.position + new Vector3(Random.Range(0, 1f), Random.Range(0, 1f)), Quaternion.identity);
            }
            _isWater = false;
        }
       
    }
    private void FixedUpdate()
    {
        if (_isWater)
        {
            UpdateAverage();
        }
    }
    
    public void AddNewWater(GameObject water)
    {
        if (!_waterPull.Contains(water))
        {
            _waterPull.Add(water);
        }
    }

    private void UpdateAverage()
    {
        float sum = 0;

        for (int i = 0; i < _waterPull.Count; i++)
        {
            if (_waterPull[i] != null)
            {
                sum += _waterPull[i].transform.position.y;
            }
            else
            {
                _waterPull.RemoveAt(i);
            }
        }
        if (_waterPull.Count == 0)
        {
            _average = 0;
            _losePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            _average = sum / _waterPull.Count;

        }
    }
}
  
