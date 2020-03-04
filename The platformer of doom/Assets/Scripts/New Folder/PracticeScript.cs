using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PracticeScript : MonoBehaviour
{
    private UnityEvent wowiezowieagarbageevent;
    private UnityEvent ifIActuallyWasGoingToDoSomethingWithThisIdMakeItLookAtSomething;

    private void Start()
    {
        print("oh boy here we go again");
    }

    private void OnTriggerEnter(Collider other)
    {
        wowiezowieagarbageevent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        print("butts");
    }

    private void OnTriggerStay(Collider other)
    {
        ifIActuallyWasGoingToDoSomethingWithThisIdMakeItLookAtSomething.Invoke();
    }
}
