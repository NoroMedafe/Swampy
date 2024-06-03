using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] private Text _countStars;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _finishMenu;
    [SerializeField] private GameObject _clipper;
    [SerializeField] private GameObject _buttonExit;

    public void FinishAnimation(int countStar)
    {
        _finishMenu.SetActive(true);
        switch (countStar)
        {
            case 1:
                _animator.Play("FirishAnimation1");
                break;
            case 2:
                _animator.Play("FirishAnimation2");
                break;
            case 3:
                _animator.Play("FirishAnimation");
                break;
        }
        _clipper.SetActive(false);
        _buttonExit.SetActive(false);
    }

}
