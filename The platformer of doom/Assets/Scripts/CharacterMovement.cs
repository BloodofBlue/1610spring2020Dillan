using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    public float characterSpeed = 5f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    void Start()
    {
        

    }
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*characterSpeed;

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }

        positionDirection.z = Input.GetAxis("Vertical")*characterSpeed;

        positionDirection.y += gravity;
        
        
        
        controller.Move(positionDirection*Time.deltaTime);

    }


}
