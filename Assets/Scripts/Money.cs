using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Money : MonoBehaviour
{
    public TMP_Text moneyText;

    private void Awake()
    {
        SettingsData.coins = PlayerPrefs.GetInt("Coins");
        moneyText.text = SettingsData.coins.ToString();
    }
}