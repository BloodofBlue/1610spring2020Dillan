using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemPickup : MonoBehaviour
{
    public UnityEvent getPickedUp;
    public UnityEvent effectRemove;
    public FloatData powerupTime;

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(powerupTime.value);
        effectRemove.Invoke();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        getPickedUp.Invoke();
        StartCoroutine("Wait");
        
    }
}
