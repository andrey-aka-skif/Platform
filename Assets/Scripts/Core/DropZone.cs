using PlatformGame.Infrastructure;
using System;
using UnityEngine;

namespace PlatformGame.Core
{
    public class DropZone : MonoBehaviour, ILoseEventSource
    {
        public event Action Lose;
        private void OnTriggerEnter(Collider coin)
        {

        }
    }
}
