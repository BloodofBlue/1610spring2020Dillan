using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int triggeringInteger;
    public float triggeringFloat;
    public string triggeringString;

    public UnityEvent enterTheVortex;
    public UnityEvent exitTheVortex;
    public UnityEvent stayInTheVortex;

    private void OnTriggerEnter(Collider other)
    {
        enterTheVortex.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        exitTheVortex.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        stayInTheVortex.Invoke();
    }
}
