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

    [HideInInspector] public bool stop;

    private void Start()
    {
        switch (SettingsData.setTextureIndex)
        {
            case 3:
                maxAddCoins++;
                break;
            case 5:
                minAddCoins++;
                maxAddCoins++;
                break;
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(sleepTimeAtStart);
        while (!stop && Time.timeScale > 0)
        {
            yield return new WaitForSeconds(
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
        // if mode - 0 (Easy), max = maxAddCoins            (3)
        // if mode - 1 (Normal), max = maxAddCoins + 1      (4)
        // if mode - 2 (Hard), max = maxAddCoins + 3        (6)
        Money.AddMoney(Random.Range(minAddCoins, maxAddCoins + Mathf.RoundToInt(SettingsData.mode * 1.4f)));
        money.moneyText.text = Money.Coins.ToString();
    }
}