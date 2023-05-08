using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar_mario : MonoBehaviour
{
    public Vector3 andar;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += andar;
    }
}
