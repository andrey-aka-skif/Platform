using UnityEngine;

namespace PlatformGame
{
    public class AgregationRoot : MonoBehaviour
    {
        [SerializeField] private Texture _texture;

        [SerializeField] private Settings _settings;
        [SerializeField] private Platform _platform;
        [SerializeField] private PlatformScaler _scaler;

        private void Awake()
        {
            
        }
    }
}
