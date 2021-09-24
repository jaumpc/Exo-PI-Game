using UnityEngine;

namespace SimplePlatform
{
    [RequireComponent(typeof(BoxCollider))]
    public class Feet : MonoBehaviour
    {
        [SerializeField] new BoxCollider collider;
        [SerializeField] LayerMask ignoreLayer;
        void Start()
        {
            if (!collider) collider = GetComponent<BoxCollider>();
        }
        public bool IsGrounded() => Physics.CheckBox(
            center: transform.position,
            halfExtents: collider.bounds.extents,
            orientation: Quaternion.identity,
            layermask: ignoreLayer,
            queryTriggerInteraction: QueryTriggerInteraction.Collide);
    }
}