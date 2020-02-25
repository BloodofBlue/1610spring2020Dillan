using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerFellBehavior : MonoBehaviour
{
    public UnityEvent playerGotDead;

    private void OnTriggerEnter(Collider other)
    {
        playerGotDead.Invoke();
    }
}
