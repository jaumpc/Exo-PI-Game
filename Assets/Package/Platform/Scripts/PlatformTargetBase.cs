using UnityEngine;

namespace SimplePlatform
{
    public class PlatformTargetBase : MonoBehaviour
    {
        #region -------- FIELDS
        [SerializeField] protected Transform target;
        [SerializeField] bool isEnabled = true;
        protected Transform originalParent;
        protected PlatformDetector currentPlatform;
        #endregion //FIELDS

        #region -------- PROPERTIES
        public bool IsEnabled => isEnabled;
        #endregion //PROPERTIES

        #region -------- METHODS
        protected virtual void Start() => originalParent = target.parent;
        public void SetEnabled(bool enabled) => isEnabled = enabled;
        protected bool IsOnPlatform(PlatformDetector platform) => currentPlatform == platform;
        protected void LeavePlatform()
        {
            if (!IsEnabled) return;

            currentPlatform = null;
            target.SetParent(originalParent);
        }
        protected void SetPlatform(PlatformDetector platform)
        {
            if (!IsEnabled) return;

            currentPlatform = platform;
            platform.AddTarget(this.target);
        }
        #endregion //METHODS
    }
}