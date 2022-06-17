using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int menuSceneIndex;
    [SerializeField] private int shopSceneIndex = 1;
    [SerializeField] private int playSceneIndex = 2;

    private void Awake()
    {
        SceneManager.sceneLoaded += FindObjectOfType<PlatformTexture>().OnSceneLoaded;
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(menuSceneIndex);
    }

    public void LoadShop()
    {
        SceneManager.LoadScene(shopSceneIndex);
    }

    public void LoadPlay()
    {
        SceneManager.LoadScene(playSceneIndex);
    }
}