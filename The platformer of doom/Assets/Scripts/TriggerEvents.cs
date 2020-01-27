using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterExitEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        print("Get the fuck outta here m80");
    }
}