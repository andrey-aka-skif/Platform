using PlatformGame.Setup;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PlatformGame.Core
{
    [RequireComponent(typeof(Platform))]
    public class PlatformScaler : MonoBehaviour
    {
        private const float DEPTH_DEFAULT = 0.3f;

        private Platform _platform;
        private IReadOnlyList<PlatformSizeScalePare> _sizes = new List<PlatformSizeScalePare>();
        private float _platformDepth;

        public void Init(IReadOnlyList<PlatformSizeScalePare> sizes, float platformDepth = DEPTH_DEFAULT)
        {
            _sizes = sizes;
            _platformDepth = platformDepth;
            _platform = GetComponent<Platform>();
            _platform.PlatformResize += OnPlatformScaled;
        }

        private void OnPlatformScaled()
        {
            float scale = 1;

            var sizeQueryResult = _sizes.Where(x => x.Size == _platform.Size);

            if (sizeQueryResult.Any())
                scale = sizeQueryResult.First().Scale;

            transform.localScale = new(scale, _platformDepth, scale);
        }
    }
}
