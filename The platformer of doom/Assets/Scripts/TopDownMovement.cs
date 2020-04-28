using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(CharacterController))]
public class TopDownMovement : MonoBehaviour
{
        private CharacterController controllerTop;
        private Vector3 positionDirectionTop;
        public float characterSpeed = 5f;
        public float gravity = -1f;
        public FloatData jumpForce;
        void Start()
        {
            controllerTop = GetComponent<CharacterController>();
    
        }
        void Update()
        {
            positionDirectionTop.x = Input.GetAxis("Horizontal")*characterSpeed;

            positionDirectionTop.z = Input.GetAxis("Vertical") * characterSpeed;
            
            controllerTop.Move(positionDirectionTop*Time.deltaTime);
    
    
        }
}
