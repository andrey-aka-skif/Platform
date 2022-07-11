using ObsoleteScripts;
using TMPro;
using UnityEngine;

namespace ObsoleteScripts
{
    [System.Obsolete]
    public class Money : MonoBehaviour
    {
        public TMP_Text moneyText;
        public static int Coins { get; private set; }

        private void Awake()
        {
            //PlayerPrefs.SetInt("Coins", 10000);
            SettingsData.coins = PlayerPrefs.GetInt("Coins");
            Coins = SettingsData.coins;
            moneyText.text = SettingsData.coins.ToString();
        }

        public static void SaveMoney()
        {
            PlayerPrefs.SetInt("Coins", SettingsData.coins);
            Coins = SettingsData.coins;
        }

        public static void AddMoney(int addMoney)
        {
            SettingsData.coins += addMoney;
            SaveMoney();
        }

        public static void ReduceMoney(int reduceMoney)
        {
            SettingsData.coins -= reduceMoney;
            SaveMoney();
        }
    }
}
