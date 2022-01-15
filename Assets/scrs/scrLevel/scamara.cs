using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class scamara : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate=60;//el juego intentara ir a 60 fps
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.position += new Vector3(6*Time.deltaTime,0,0);
        }
    }
}
