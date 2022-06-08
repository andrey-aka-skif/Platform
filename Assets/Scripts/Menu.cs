using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdownMode;
    [SerializeField] private TMP_Text moneyText;

    private void Start()
    {
        SettingsData.coins = PlayerPrefs.GetInt("Coins");
        moneyText.text = $"Coins: {SettingsData.coins}";
        ResetMode();
    }

    public void ResetMode()
    {
        SettingsData.mode = dropdownMode.value;
        print(dropdownMode.value + " - " + SettingsData.mode);
    }
}