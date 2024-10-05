using UnityEngine;

namespace Polyperfect.Universal
{
    public class PlayerMovement : MonoBehaviour
    {

        public CharacterController controller;
        public float speed = 12f;
        public float gravity = -9.81f;
        

        public Transform groundCheck;
        public float groundDistance = 0.0f;


        Vector3 velocity;
        bool isGrounded;

        // Update is called once per frame
        void Update()
        {
            controller = GetComponent<CharacterController>();
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance);

            if (isGrounded && velocity.y < 0)
            {
                controller.slopeLimit = 45.0f;
                velocity.y = -2f;
            }


            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            if (move.magnitude > 1)
                move /= move.magnitude;
            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);




        }
    }
}