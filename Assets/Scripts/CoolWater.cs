using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolWater : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<DeadWater>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
