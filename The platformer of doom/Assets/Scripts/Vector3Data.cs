﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Vector3Data : MonoBehaviour
{
    public Vector3 value;

    public void ChangePosition(Transform transformObj)
    {
        transformObj.position = value;
    }

    public void ChangeValueFromTransform(Transform transformObj)
    {
        value = transformObj.position;
    }

    public void ChangeVector3Data(Vector3Data vector3DataObj)
    {
        vector3DataObj.value = value;
    }

}
