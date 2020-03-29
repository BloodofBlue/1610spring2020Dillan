using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IScreamForIAmIdealess : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public UnityEvent mouseUpEvent;
    public UnityEvent mouseDragEvent;
    public UnityEvent mouseOverEvent;
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.magenta
    }

    private void OnMouseEnter()
    {
        print("screeee");
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
        transform.Rotate(Vector3.left);
    }
}
