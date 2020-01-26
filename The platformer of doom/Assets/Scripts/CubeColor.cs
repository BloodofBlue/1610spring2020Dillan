using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This code came from the scripts and behavior tutorial on learn.unity.com. Except the last little bit, I added that myself.
public class CubeColor : MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("fart");
        }
    }
}
