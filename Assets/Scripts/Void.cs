using TMPro;
using UnityEngine;

public class Void : MonoBehaviour
{
    private static bool _stop;
    private static readonly int Open = Animator.StringToHash("Open");

    [SerializeField] private Animator losePanel;
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private TMP_Text maxCoinsText;
    private AdsController _adsController;

    private void Awake()
    {
        _stop = false;
        _adsController = FindObjectOfType<AdsController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_stop || !other.CompareTag("Coin")) return;

        _stop = true;

        var coins = SettingsData.coins;
        if (coins > PlayerPrefs.GetInt("MaxCoins")) PlayerPrefs.SetInt("MaxCoins", coins);
        PlayerPrefs.SetInt("Coins", coins);

        losePanel.SetTrigger(Open);
        coinsText.text = "Coins: " + coins;
        maxCoinsText.text = "Max coins: " + PlayerPrefs.GetInt("MaxCoins");

        if (Random.Range(1, 3) == 1) _adsController.ShowAd();
        //_adsController.ShowAd();
    }
}