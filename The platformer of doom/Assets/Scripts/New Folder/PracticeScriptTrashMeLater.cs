using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PracticeScriptTrashMeLater : MonoBehaviour
{
    public UnityEvent mouseDown;
    public UnityEvent mouseUp;
    public UnityEvent mouseDrag;
    public UnityEvent mouseOver;

    private void OnMouseUpAsButton()
    {
        print("noot noot");
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnMouseDown()
    {
        mouseDown.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUp.Invoke();
    }
}
