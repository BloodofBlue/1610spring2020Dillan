using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetBaseValues : MonoBehaviour
{
    public UnityEvent resetValues;
    void Start()
    {
        resetValues.Invoke();
    }

}
