using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterChecker : MonoBehaviour
{
    [SerializeField] private CameraMover _spawner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Fluid>())
        {
            _spawner.GetSpawner.AddNewWater(collision.gameObject);
        }
    }
   
}
