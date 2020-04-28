using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public GameObject [] objs;
    
    
    void Start()
    {
        for(int i = 0; i < objs.Length; i++)
        {
            print(objs[i]);
        }

        foreach (GameObject obj in objs)
        {
            print(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
