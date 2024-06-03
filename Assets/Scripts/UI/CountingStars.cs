using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingStars : MonoBehaviour
{
    public static CountingStars Instansce { get; private set; }

    [SerializeField] private Text _text;
    [SerializeField] private Finish _compliteMenu;
    [SerializeField] private SaveStars _saveStars;

    private int _currentCountStars = 0;

    public void AccrualStar()
    {
        _currentCountStars+= 1;
        _text.text = _currentCountStars.ToString();
    }

    public void EndingAccuralStar()
    {
        AccrualStar();
        Invoke(nameof(FinishMenu), 2);
    }

    private void FinishMenu()
    {
        _compliteMenu.FinishAnimation(_currentCountStars);
        _saveStars.RecordStars(_currentCountStars);
    }
    private void OnEnable()
    {
        if (Instansce == null)
        {
            Instansce = this;
        }
    }
    private void OnDisable()
    {
        if (Instansce == this)
        {
            Instansce = null;
        }
    }
}
