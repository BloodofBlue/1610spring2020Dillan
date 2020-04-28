﻿using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;

    public void ChangeString(string line)
    {
        value = line;
    }
}
