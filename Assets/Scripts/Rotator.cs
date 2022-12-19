using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.up);
    }
}
