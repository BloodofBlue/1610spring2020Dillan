using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorController : MonoBehaviour
{
    public IntData doorCount;
    public int doorNumber;
    public UnityEvent doorOpen;
    void Update()
    {
        if (doorCount.value >= doorNumber)
        {
            doorOpen.Invoke();
        }
    }
}
