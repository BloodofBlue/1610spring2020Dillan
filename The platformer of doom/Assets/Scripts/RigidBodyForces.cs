using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class RigidBodyForces : MonoBehaviour
{
   private Rigidbody rigidBodyObj;
   public float force = 100;
   private Vector3 forceVector;

   private void Start()
   {
      rigidBodyObj = GetComponent<Rigidbody>();
   }

   private void OnCollisionEnter(Collision other)
   {
      print("hey dont touch me");
   }
}
