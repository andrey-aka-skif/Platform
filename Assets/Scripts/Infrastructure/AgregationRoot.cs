using PlatformGame.Core;
using PlatformGame.Setup;
using UnityEngine;

namespace PlatformGame.Infrastructure
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
