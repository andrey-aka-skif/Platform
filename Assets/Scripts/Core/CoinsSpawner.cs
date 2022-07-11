using PlatformGame.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Core
{
    public class CoinsSpawner : MonoBehaviour, IManaged
    {
        public event Action CoinDropOnPlatform;

        private List<SpawnPoint> _spawnPoints;
        private CoinsPool _pool;
        private List<Coin> _spawnedCoins;

        public void Init()
        {

        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Restart()
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        private void OnCoinDropedOnPlatform(Coin coin)
        {

        }
        IEnumerator Spawn()
        {
            return null;
        }
    }
}
