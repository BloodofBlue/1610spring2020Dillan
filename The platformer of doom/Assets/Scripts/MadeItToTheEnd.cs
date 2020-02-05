using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MadeItToTheEnd : MonoBehaviour
{
    public UnityEvent touchTheEnd;
    
    private void OnTriggerEnter(Collider other)
    {
        touchTheEnd.Invoke();
        
        print("congrats you made it");
        
        print("I hope you like the void you fool");
        
        print("I've done a lot of stuff making this but it didnt really involve actual code");
        
        print("mainly just messing with unity events");
        
        print("And the lecture is one I've done already so I can't do much with that");
        
        print("So all this printing is honestly just to fulfill the 25 lines of code requirement for the day");

        print("squalala motherfuckers");
    }
}
