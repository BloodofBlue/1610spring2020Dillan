using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecopyforpractice : MonoBehaviour
{
    
    public CharacterController controller;
    private Vector3 positionDirection;
    public float characterspeed = 5f;
    public float jumpForce = 15f;
    public float gravity = -1f;
    
   
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal") * characterSpeed;

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }

        positionDirection.z = Input.GetAxis("Vertical") * characterSpeed;
        positionDirection.y += gravity;

        controller.Move(positionDirection * Time.deltaTime);

    }
}
