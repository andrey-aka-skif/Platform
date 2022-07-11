using UnityEngine;

namespace PlatformGame.Core
{
    [RequireComponent(typeof(Platform), typeof(Renderer))]
    public class SkinChanger : MonoBehaviour
    {
        private Platform _platform;
        private Renderer _renderer;

        public void Init()
        {
            _renderer = GetComponent<Renderer>();
            _platform = GetComponent<Platform>();
            _platform.PlatformSkinApply += SkinApplyed;
        }

        private void SkinApplyed()
        {
            _renderer.material.mainTexture = _platform.Skin.Texture;
        }
    }
}
