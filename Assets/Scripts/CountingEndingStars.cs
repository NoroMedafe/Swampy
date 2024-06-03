using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingEndingStars : MonoBehaviour
{
    [SerializeField] private GameObject _endingEffect;

    public void AccuralEndingStar()
    {
        _endingEffect.SetActive(true);
        CountingStars.Instansce.EndingAccuralStar();

    }
}
