using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(CharacterController))]
public class DeleteMe : MonoBehaviour
{ 
    private CharacterController controller;
    private Vector3 positionDirection;
    public float characterSpeed = 5f;
    public float gravity = -1f;
    public float jumpForce = 15f;
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*characterSpeed;
        
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }
        
        positionDirection.y += gravity;
        
        controller.Move(positionDirection*Time.deltaTime);


    }


}
