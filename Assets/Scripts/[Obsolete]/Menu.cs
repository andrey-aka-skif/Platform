using TMPro;
using UnityEngine;

namespace ObsoleteScripts
{
    [System.Obsolete]
    public class Menu : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown dropdownMode;
        [SerializeField] private TMP_Text moneyText;
        [SerializeField] private GameObject msgBox;

        private void Awake()
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            SettingsData.coins = PlayerPrefs.GetInt("Coins");
            moneyText.text = $"Coins: {SettingsData.coins}";
            ResetMode();
        }

        public void ResetMode()
        {
            SettingsData.mode = dropdownMode.value;
        }

        public void ShowMsgBox()
        {
            msgBox.SetActive(true);
        }

        public void ImSure()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("Item0", 1);
            for (var i = 1; i < 100; i++) PlayerPrefs.SetInt("Item" + i, 0);
            msgBox.SetActive(false);
            FindObjectOfType<SceneLoader>().Reload();
        }

        public void ImNotSure()
        {
            msgBox.SetActive(false);
        }
    }
}
