using UnityEngine;

namespace SimplePlatform
{
    public class SimpleJump : MonoBehaviour
    {
        [SerializeField] float jumpForce = 1;
        [SerializeField] KeyCode jumpKey = KeyCode.Space;
        SimpleRigidBody rb;
        void Start() => rb = GetComponentInChildren<SimpleRigidBody>();
        void Update() => HandleJump();
        void HandleJump()
        {
            if (CanJump())
                Jump();
        }
        bool CanJump()
        {
            if (!IsGrounded()) return false;
            return Input.GetKeyDown(jumpKey);
        }
        bool IsGrounded() => rb.IsGrounded;
        void Jump() => rb.velocity.y = jumpForce;
    }
}