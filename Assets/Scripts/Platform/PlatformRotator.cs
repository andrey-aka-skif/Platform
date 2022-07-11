using UnityEngine;

namespace PlatformGame
{
    [RequireComponent(typeof(Platform))]
    public class PlatformRotator : MonoBehaviour
    {
        private Platform _platform;

        public void Init()
        {
            _platform = GetComponent<Platform>();
            _platform.PlatformRotate += OnPlatformRotated;
        }

        private void OnPlatformRotated()
        {
            transform.localEulerAngles = new Vector3(0, 0, _platform.Angle.Value);
        }
    }
}
