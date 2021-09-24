using UnityEngine;

namespace SimplePlatform
{
    public class PlatformTargetBase : MonoBehaviour
    {
        [SerializeField] protected Transform platform;
        protected Transform originalParent;
        protected PlatformDetector currentPlatform;
        protected virtual void Start() => originalParent = platform.parent;
        protected bool IsOnPlatform(PlatformDetector platform) => currentPlatform == platform;
        protected void LeavePlatform()
        {
            currentPlatform = null;
            platform.SetParent(originalParent);
        }
        protected void SetPlatform(PlatformDetector platform)
        {
            currentPlatform = platform;
            platform.AddTarget(this.platform);
        }
    }
}