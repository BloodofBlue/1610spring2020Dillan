﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    private Text textObj;
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    public IntData dataObj;
    void Start()
    {
        textObj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textObj.text = dataObj.value.ToString();
    }
}
