using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barn : MonoBehaviour
{
    [SerializeField] private WaterTrigger _waterTrigger;
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animatorHome;
    [SerializeField] private Animator _animatorTree;


    private void RestoringPlatform()
    {
        _animatorHome.SetTrigger("Start");
        _animatorTree.SetTrigger("Water");

    }

    private void OnEnable()
    {
        _waterTrigger.WaterAbundance += RestoringPlatform;
    }
    private void OnDisable()
    {
        _waterTrigger.WaterAbundance -= RestoringPlatform;

    }
}
