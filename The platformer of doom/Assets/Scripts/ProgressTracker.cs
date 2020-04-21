using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProgressTracker : MonoBehaviour
{
    public FloatData levelProgress;
    public UnityEvent unlockNextDoor;
    void Update()
    {
        if (levelProgress.value >= 1)
        {
            unlockNextDoor.Invoke();
        }
    }
}
