using UnityEngine;

namespace SimplePlatform
{
    [RequireComponent(typeof(Collider))]
    public class PlatformDetector : MonoBehaviour
    {
        [SerializeField] Transform newParent;
        public void AddTarget(Transform target) => target.SetParent(newParent);
    }
}