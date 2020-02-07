using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraLockedOn : MonoBehaviour
{
    public UnityEvent orthographicCameraLockOn;
    void Update()
    {
        orthographicCameraLockOn.Invoke();
    }
}
