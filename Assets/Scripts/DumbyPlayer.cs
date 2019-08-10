﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbyPlayer : MonoBehaviour
{
    public InputHandler Io;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputBuffer = Io.Poll();

        transform.position += new Vector3(inputBuffer.LeftAxisVertical * Time.deltaTime, inputBuffer.LeftAxisHorizontal * Time.deltaTime, 0);
    }
}
