using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class VariablesTutorial : MonoBehaviour
{
    private int myInt = 5;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log();
    }

    int MultiplyByTwo(int number)
    {
        Int ret;
        ret = number * 2;
        return ret;
    }
    
    //THis code came from a tutorial on the unity website, will cite specific one later.
    
    //it was the second one
}    