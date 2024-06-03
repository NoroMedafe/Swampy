using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private GameObject _effectStars;
    private bool _isActive = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Fluid>() && _isActive)
        {
            _isActive = false;

            CountingStars.Instansce.AccrualStar();
            _effectStars.SetActive(true);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.GetComponent<DeadWater>())
        {
            Destroy(gameObject);
        }
    }
}
