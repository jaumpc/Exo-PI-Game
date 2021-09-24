using UnityEngine;

namespace SimplePlatform
{
    public class SimpleRigidBody : MonoBehaviour
    {
        const float BASE_GRAVITY = -9.81f;
        [SerializeField] CharacterController target;
        [SerializeField] float gravityMultiplier = 1;
        [SerializeField] Feet feet;
        public Vector3 velocity;
        [SerializeField] bool isGrounded;
        public bool IsGrounded => feet.IsGrounded();
        void FixedUpdate()
        {
            isGrounded = feet.IsGrounded();
            HandleGravity();
            ApplyVelocity();
        }
        void HandleGravity()
        {
            if (velocity.y <= 0 && feet.IsGrounded()) velocity.y = 0;
            else velocity.y += BASE_GRAVITY * gravityMultiplier * Time.fixedDeltaTime;
        }
        void ApplyVelocity() => target.Move(velocity * Time.fixedDeltaTime);
    }
}