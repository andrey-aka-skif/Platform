using System;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private AudioSource noMoneySound;
    [SerializeField] private TMP_Text moneyTMPText;
    [SerializeField] private GameObject[] locks;
    [SerializeField] private ButtonListener[] items;
    private PlatformTexture _platformTexture;

    private void Awake()
    {
        _platformTexture = FindObjectOfType<PlatformTexture>();
        locks[0].SetActive(false);
        for (var i = 1; i < locks.Length; i++) locks[i].SetActive(PlayerPrefs.GetInt($"Item{i}") == 0);
        foreach (var item in items) item.VoidAwake();
    }

    public void SetTextureIndex(int index, int cost)
    {
        var isBought = PlayerPrefs.GetInt($"Item{index}") == 1;
        var money = Money.Coins;

        if (!isBought)
        {
            if (money < cost)
            {
                noMoneySound.Play();
                return;
            }

            Money.ReduceMoney(cost);
            moneyTMPText.text = Money.Coins.ToString();
            PlayerPrefs.SetInt($"Item{index}", 1);
            locks[index].SetActive(false);
        }

        _platformTexture.TextureIndex = index;
    }
}