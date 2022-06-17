using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListener : MonoBehaviour
{
    [SerializeField] private Shop shop;
    private Button _button;

    public void VoidAwake()
    {
        _button = GetComponent<Button>();
        if (shop == null) shop = FindObjectOfType<Shop>();
        var index = SettingsData.index;
        var cost = SettingsData.Costs[^(index+1)];
        _button.onClick.AddListener(() => shop.SetTextureIndex(index, cost));
        SettingsData.index++;
    }

    private void OnDisable()
    {
        SettingsData.index = 0;
        _button.onClick.RemoveAllListeners();
    }
}