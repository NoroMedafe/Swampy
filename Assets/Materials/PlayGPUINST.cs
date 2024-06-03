using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGPUINST : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private void Awake()
    {
        MaterialPropertyBlock materialProperty = new MaterialPropertyBlock();
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.SetPropertyBlock(materialProperty);

    }
}
