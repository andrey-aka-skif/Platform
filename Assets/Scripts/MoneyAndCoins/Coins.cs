using System.Collections;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] private Transform[] randomSpawnPoints;
    [SerializeField] private GameObject[] randomCoins;
    [SerializeField] private float sleepTimeAtStart;

    [SerializeField] private float minTimeSpawn;
    [SerializeField] private float maxTimeSpawn;

    [SerializeField] private int minAddCoins = 1;
    [SerializeField] private int maxAddCoins = 3;

    [HideInInspector] public bool Stop;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSecondsRealtime(sleepTimeAtStart);
        while (!Stop)
        {
            yield return new WaitForSecondsRealtime(
                Random.Range(minTimeSpawn, maxTimeSpawn - SettingsData.mode * 0.5f));

            var coin = randomCoins[Random.Range(0, randomCoins.Length)];
            var spawnVector = randomSpawnPoints[Random.Range(0, randomSpawnPoints.Length)].position;

            Instantiate(coin, spawnVector, Random.rotation);

            StartCoroutine(AddMoney());
        }
    }

    private IEnumerator AddMoney()
    {
        yield return new WaitForSeconds(1);
        SettingsData.coins += Random.Range(minAddCoins, maxAddCoins + Mathf.RoundToInt(SettingsData.mode * 1.5f));
        money.moneyText.text = SettingsData.coins.ToString();
    }
}