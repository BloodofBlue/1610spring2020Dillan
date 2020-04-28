using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Add(3,6);
       Add(7,6);
       int returnedNumber = addReturn(6, 8);
       print(returnedNumber);
    }

    public void Add(int a, int b)
    {
        int c = a + b;
        print(c);
    }

    public int addReturn(int a, int b)
    {
        return a + b;
    }
}
