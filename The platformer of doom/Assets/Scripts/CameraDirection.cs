using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraDirection : MonoBehaviour
{
    public UnityEvent lookAtThePlayer;
    void Update()
    {
        lookAtThePlayer.Invoke();
    }
}
