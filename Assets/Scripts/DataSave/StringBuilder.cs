using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StringBuilder : MonoBehaviour
{
    private string glyphs= "_*abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_*"; //add the characters you want
    private string baseNums = "0123456789";

    private int charAmount = 20;
    private int numsAmount = 16;

    public string newString;
    public string newInt;

    public void GetRandomCharString()
    {
        CreateNewCharString();
    }
    
    public void GetRandomIntString()
    {
        CreateNewIntString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            newString = CreateNewCharString();
        }
    }

    public string CreateNewCharString() {
        newString = null;
        for(int i=0; i<charAmount; i++) {
            newString += glyphs[Random.Range(0, glyphs.Length)];
        }
        return newString;
    }

    public string CreateNewIntString() {
        newInt = null;
        for(int i=0; i<numsAmount; i++)
        {
            newInt += baseNums[Random.Range(0, baseNums.Length)];
        }
        return newInt;
    }



}
