using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SubwayColor : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        meshRenderer.material.color = Color.blue;
    }
}
