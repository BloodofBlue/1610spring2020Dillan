using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemPickup : MonoBehaviour
{
    public UnityEvent getPickedUp;
    private void OnTriggerEnter(Collider other)
    {
        getPickedUp.Invoke();
    }
}
