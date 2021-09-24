using UnityEngine;

namespace SimplePlatform
{
    public class PlatformTargetTrigger : PlatformTargetBase
    {
        void OnTriggerEnter(Collider other)
        {
            PlatformDetector platform = other.GetComponentInChildren<PlatformDetector>();
            if (platform)
                SetPlatform(platform);
        }
        void OnTriggerExit(Collider other)
        {
            PlatformDetector platform = other.GetComponentInChildren<PlatformDetector>();
            if (platform && IsOnPlatform(platform))
                LeavePlatform();
        }
    }
}