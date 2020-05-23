using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float speed = 20.0f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
