using UnityEngine;

namespace SimplePlatform
{
    public class SimpleMove : MonoBehaviour
    {
        [SerializeField] float speed = 1;
        [SerializeField] string xAxis = "Horizontal";
        [SerializeField] string yAxis = "Vertical";
        SimpleRigidBody rb;
        void Start() => rb = GetComponentInChildren<SimpleRigidBody>();
        void Update() => HandleMovement();
        void HandleMovement()
        {
            float x = Input.GetAxis(xAxis);
            float z = Input.GetAxis(yAxis);
            Vector3 motion = new Vector3(x, 0, z) * speed * Time.deltaTime;
            Move(motion);
        }
        void Move(Vector3 motion)
        {
            rb.velocity.x = motion.x;
            rb.velocity.z = motion.z;
        }
    }
}