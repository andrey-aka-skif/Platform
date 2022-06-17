using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListener : MonoBehaviour
{
    [SerializeField] private Shop shop;
    [SerializeField] private TMP_Text costTMPText;
    private Button _button;

    private void OnDisable()
    {
        SettingsData.index = 0;
        _button.onClick.RemoveAllListeners();
    }

    public void VoidAwake()
    {
        _button = GetComponent<Button>();
        if (shop == null) shop = FindObjectOfType<Shop>();
        if (costTMPText == null) costTMPText = GetComponentInChildren<TMP_Text>();
        var index = SettingsData.index;
        var cost = SettingsData.Costs[index];
        costTMPText.text = cost.ToString();
        _button.onClick.AddListener(() => shop.SetTextureIndex(index, cost));
        SettingsData.index++;
    }
}