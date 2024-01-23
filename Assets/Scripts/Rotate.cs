using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed, 0);
    }
}
