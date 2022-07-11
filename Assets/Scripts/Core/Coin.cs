using System;
using UnityEngine;

namespace PlatformGame.Core
{
    public class Coin : MonoBehaviour
    {
        public event Action<Coin> CoinDropOnPlatform;

        private CoinType _coinType;

        public void Pause()
        {

        }
        public void Resume()
        {

        }

        private void OnCollisionEnter(Collision platform)
        {

        }
    }
}
