﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWeb : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openWeb()
    {
        Application.OpenURL("https://www.ndfdev.com/");
    }
    public void openPhone()
    {
        Application.OpenURL("tel://[+66-908914504]"); 
    }
}

