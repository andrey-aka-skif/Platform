using PlatformGame.Setup;
using System;
using UnityEngine;

namespace PlatformGame.Core
{
    public class Platform : MonoBehaviour
    {
        public event Action PlatformResize;
        public event Action PlatformSkinApply;
        public event Action PlatformRotate;

        public PlatformSize Size { get; private set; }
        public Skin Skin { get; private set; }
        public Angle Angle { get; private set; }

        private IRotator _rotator;
        private IPlatformRepository _repository;

        public void Init(IRotator rotator, PlatformSize size, IPlatformRepository repository)
        {
            _rotator = rotator;
            Size = size;
            _repository = repository;
        }

        public void ScaleTo(PlatformSize size)
        {
            Size = size;
            PlatformResize?.Invoke();
        }

        public void ApplySkin(Skin skin)
        {
            Skin = skin;
            PlatformSkinApply?.Invoke();
        }

        private void Update()
        {
            PlatformRotate?.Invoke();
        }
    }
}
