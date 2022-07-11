using PlatformGame.Ads;
using System.Collections;
using TMPro;
using UnityEngine;

namespace ObsoleteScripts
{
    [System.Obsolete]
    public class Lose : MonoBehaviour
    {
        private static bool _stop;
        private static readonly int Open = Animator.StringToHash("Open");

        [SerializeField] private Animator losePanel;
        [SerializeField] private TMP_Text coinsText;
        [SerializeField] private TMP_Text maxCoinsText;
        [SerializeField] private AdsController adsController;

        private int _amountCoinsBefore;

        private void OnEnable()
        {
            Time.timeScale = 1;
            _stop = false;
            _amountCoinsBefore = Money.Coins;
            adsController ??= FindObjectOfType<AdsController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (_stop || !other.CompareTag("Coin")) return;

            _stop = true;

            var coins = SettingsData.coins;
            if (coins > PlayerPrefs.GetInt("MaxCoins")) PlayerPrefs.SetInt("MaxCoins", coins);
            Money.SaveMoney();

            losePanel.SetTrigger(Open);
            coinsText.text = $"Earned: {Money.Coins - _amountCoinsBefore}";
            maxCoinsText.text = "Max coins: " + PlayerPrefs.GetInt("MaxCoins");

            if (Random.Range(1, 4) == 1) adsController.ShowAd();
            //_adsController.ShowAd();
            StartCoroutine(StopTime());
        }

        private static IEnumerator StopTime()
        {
            yield return new WaitForSeconds(2);
            Time.timeScale = 0;
        }
    }
}
