using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public UnityEvent mouseUpEvent;
    public UnityEvent mouseDragEvent;
    public UnityEvent mouseOverEvent;


    private void OnMouseUpAsButton()
    {
        print("butts");
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnMouseEnter()
    {
        print("mingus bingus");
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
        transform.Rotate(Vector3.right);
    }

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
        GetComponent<Renderer>().material.color = Color.magenta;
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
        GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
        print("FUCK");
    }
}
