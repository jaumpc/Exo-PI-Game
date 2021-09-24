using UnityEngine;

namespace SimplePlatform
{
    [RequireComponent(typeof(Collider))]
    public class PlatformDetector : MonoBehaviour
    {
        [SerializeField] Transform pivot;
        public void AddTarget(Transform target) => target.SetParent(pivot);
    }
}