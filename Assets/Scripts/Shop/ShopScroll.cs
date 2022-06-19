using UnityEngine;

public class ShopScroll : MonoBehaviour
{
    [SerializeField] private float thrust;
    [SerializeField] private RectTransform shop;
    [SerializeField] private int maxX;
    [SerializeField] private int minX;
    [SerializeField] private bool scrollEverywhere;

    private Scroll _scroll;

    private void Start()
    {
        _scroll = FindObjectOfType<Scroll>();
    }

    private void FixedUpdate()
    {
        // if the scroll start is not within the object
        // if (!scrollEverywhere)
        //     if (_scroll.StartPosition.y > (shop.position.y + shop.sizeDelta.y) / 3 * 2 ||
        //         _scroll.StartPosition.y < Mathf.Abs(shop.position.y - shop.sizeDelta.y) / 3 * 2 ||
        //         _scroll.StartPosition.x < (shop.position.x - shop.sizeDelta.x) / 3 * 2 ||
        //         _scroll.StartPosition.x > (shop.position.x + shop.sizeDelta.x) / 3 * 2)
        //         return;

        shop.Translate(new Vector2(_scroll.ScrollValue.x * thrust, 0));
        var shopPos = shop.localPosition;
        if (shopPos.x > maxX) shopPos.x = maxX;
        else if (shopPos.x < minX) shopPos.x = minX;
        shop.localPosition = shopPos;
    }
}