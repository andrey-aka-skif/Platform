using System;
using TMPro;
using UnityEngine;

public class Void : MonoBehaviour
{
    private static bool _stop;
    private static readonly int Open = Animator.StringToHash("Open");

    [SerializeField] private Animator losePanel;
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private TMP_Text maxCoinsText;

    private void Awake()
    {
        _stop = false;
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
    }
}