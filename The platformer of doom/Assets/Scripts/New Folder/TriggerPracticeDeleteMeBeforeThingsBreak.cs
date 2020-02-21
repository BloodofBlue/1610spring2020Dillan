using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPracticeDeleteMeBeforeThingsBreak : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;
    public UnityEvent triggerStayEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        print("ohai there");
    }
    
    private void OnTriggerExit(Collider other)
    {
    triggerExitEvent.Invoke();
    print("See ya later bucko");
    }
    
    private void OnTriggerStay(Collider other)
    {
    triggerStayEvent.Invoke();
    print("AAAAAAAAAAAAAA");
    }
}
