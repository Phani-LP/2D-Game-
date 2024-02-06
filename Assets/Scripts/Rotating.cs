using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 360 * speed * Time.deltaTime));
    }
}