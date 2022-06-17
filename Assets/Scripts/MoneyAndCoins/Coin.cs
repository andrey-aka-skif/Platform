using UnityEngine;

public class Coin : MonoBehaviour
{
    private Rigidbody _rbCoin;

    private void Start()
    {
        _rbCoin = GetComponent<Rigidbody>();
        _rbCoin.sleepThreshold = 0.0f;
    }
}