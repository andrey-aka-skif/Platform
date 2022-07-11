using UnityEngine;

namespace ObsoleteScripts
{
    [System.Obsolete]
    public class Coin : MonoBehaviour
    {
        [SerializeField] private Rigidbody rigidbodyCoin;
        [SerializeField] private AudioSource audioSource;

        private void Start()
        {
            rigidbodyCoin.sleepThreshold = 0f;
        }

        private void OnCollisionEnter()
        {
            Destroy(GetComponent<AudioSource>());
            Destroy(this);
        }
    }
}
