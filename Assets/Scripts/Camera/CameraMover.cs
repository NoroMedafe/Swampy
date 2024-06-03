using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private DropSpawner _dropSpawner;

    public DropSpawner GetSpawner => _dropSpawner;

    private void Update()
    {
        float transformLerp = Mathf.Lerp(transform.position.y, _dropSpawner.Average - 5f, _speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transformLerp, transform.position.z);
        
    }
}
