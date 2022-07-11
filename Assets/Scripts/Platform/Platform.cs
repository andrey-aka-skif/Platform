using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame
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

    public interface IPoolable
    {
        void Activate();
        void Deactivate();
    }

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

    public class CoinType
    {
    }

    public class DropZone : MonoBehaviour, ILoseEventSource
    {
        public event Action Lose;
        private void OnTriggerEnter(Collider coin)
        {

        }
    }

    public class CoinsPool
    {
        public CoinsPool()
        {

        }

        public Coin GetCoin(CoinType type)
        {
            return null;
        }
        public void ReturnCoin(Coin coin)
        {

        }
        public void ReturnAllCoins()
        {

        }
        private Coin CreateNewCoin()
        {
            return null;
        }
    }

    public class SpawnPoint : MonoBehaviour { }

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

    public class ByAddedCoinScoreController : IManaged, IProgressEventSource
    {
        public event Action<int> Progress;

        private Wallet _wallet;
        private CoinsSpawner _spawner;

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

        private void OnCoinDropedOnPlatform()
        {

        }
    }

    public class ByTimeScoreController : IManaged, IProgressEventSource
    {
        public event Action<int> Progress;

        private Wallet _wallet;
        private CoinsSpawner _spawner;
        private float _delay;

        public void Init(float delay)
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

        IEnumerator Tick()
        {
            return null;
        }
    }

    public class Wallet
    {
        public event Action<int> CoinsAmountChange;

        public Money CoinsAmount { get; }

        private IWalletRepository _repository;

        public void Init()
        {

        }
        public void AddCoins(Money amount)
        {

        }
        public void RemoveCoins(Money amount)
        {

        }
    }

    public interface IWalletRepository
    {
        Money GetCoins();
        void SaveCoins(Money amount);
    }

    public class Shop
    {
        public event Action<Skin> PurchaseDone;
        public event Action<Skin> PurchaseFailure;
        public IReadOnlyList<SkinCostPare> SkinsForSale;

        public void Init()
        {

        }
        public Skin BuySkin(Skin skin)
        {
            return null;
        }
    }

    public interface IShopRepository
    {
        IReadOnlyList<SkinCostPare> GetSkins();
    }

    public class Purchases
    {
        public IReadOnlyList<Skin> PurchasedSkins { get; }

        public void Init()
        {

        }
        public void AddSkin(Skin skin)
        {

        }
    }

    public interface IPurchasesRepository
    {
        IReadOnlyList<Skin> GetPurchasedSkins();
        void SavePurchasedSkins(IReadOnlyList<Skin> skins);
    }

    public class SkinPurchasesService
    {
        public IReadOnlyList<Skin> PurchasedSkins { get; }

        private Wallet _wallet;
        private Shop _shop;
        private Purchases _purchases;

        public void Init(Shop shop, Wallet wallet, Purchases purchases)
        {

        }
        public bool TryBuySkin(Skin skin)
        {
            return false;
        }
    }

    public class BuyCommand : ICommand
    {
        public BuyCommand(Skin skin)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class SetCommand : ICommand
    {
        public SetCommand(Skin skin)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class PlatformUIProxy
    {
        private IPlatformRepository _platformRepository;

        public void Init(IPlatformRepository platformRepository)
        {

        }
        public bool TrySet(Skin skin)
        {
            return false;
        }
    }

    public class Statistics : IStatistics
    {
        public Money CoinsAmount { get; }
        public Money BestScore { get; }

        private Wallet _wallet;

        public void Init(Wallet wallet)
        {

        }
    }

    public interface IStatisticsRepository
    {
        Money GetBestScore();
        void SaveBestScore(Money score);
    }

    public class ScreenController : MonoBehaviour
    {
        public void Init()
        {

        }
    }

    public class LifeController : IManaged, ILifeEventSource
    {
        private List<IManaged> _managed;
        private List<ILoseEventSource> _loseSources;

        public event Action RestartEvent;
        public event Action PauseEvent;
        public event Action ResumeEvent;
        public event Action ExitEvent;

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
    }

    public class ResumeCommand : ICommand
    {
        public ResumeCommand(LifeController lifeController)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class PauseCommand : ICommand
    {
        public PauseCommand(LifeController lifeController)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class RestartCommand : ICommand
    {
        public RestartCommand(LifeController lifeController)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class ExitCommand : ICommand
    {
        public ExitCommand(LifeController lifeController)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class ShopSoundManager : MonoBehaviour
    {
        private Shop _shop;

        public void Init(Shop shop)
        {

        }

        private void OnPurchaseDoned()
        {

        }
        private void OnPurchaseFailured()
        {

        }

        private void PlayPurchaseDonedSound()
        {

        }
        private void PlayPurchaseFailuredSound()
        {

        }
    }

    public class CoinsSoundManager : MonoBehaviour
    {
        private CoinsSpawner _spawner;

        public void Init(CoinsSpawner spawner)
        {

        }

        private void OnCoinDropedOnPlatform()
        {

        }

        private void PlayCoinSound()
        {

        }
    }

    public class GameSoundManager : MonoBehaviour
    {
        private ILifeEventSource _lifeEventSource;

        public void Init(ILifeEventSource lifeEventSource)
        {

        }

        private void OnRestart()
        {

        }
        private void OnPause()
        {

        }
        private void OnResume()
        {

        }
        private void OnExit()
        {

        }

        private void PlayGameplaySound()
        {

        }
        private void PlayPauseSound()
        {

        }
        private void PlayExitSound()
        {

        }
    }

    public class SkinCostPare
    {
        public Skin Skin { get; }
        public Money Coast { get; }
    }

    public interface ICommand
    {
        void Execute();
    }
}
