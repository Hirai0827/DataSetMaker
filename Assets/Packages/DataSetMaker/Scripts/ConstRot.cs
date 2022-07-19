using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstRot : MonoBehaviour
{
    [SerializeField] private float speed;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0.0f,1.0f,0.0f),speed * Time.deltaTime);
    }
}
