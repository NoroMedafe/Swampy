using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverOnX : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField]private float _positionX;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 positionCamera = _camera.transform.position;
        _camera.transform.position = new Vector3(Mathf.MoveTowards(positionCamera.x, _positionX, 0.2f), positionCamera.y,positionCamera.z);
     //   Mathf.MoveTowards(positionCamera.x, _positionX, 0.3f);
    }
}
