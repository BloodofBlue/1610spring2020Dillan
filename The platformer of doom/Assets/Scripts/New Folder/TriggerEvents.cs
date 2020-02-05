using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterExitEvent;
    public UnityEvent triggerExitEventButSnazzier;
    public UnityEvent stayingInTheTriggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterExitEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        stayingInTheTriggerEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEventButSnazzier.Invoke();
        print("Get the fuck outta here m80");
    }
}