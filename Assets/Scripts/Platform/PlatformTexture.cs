using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformTexture : MonoBehaviour
{
    [SerializeField] private Texture[] textureMaterials;
    public static int textureIndex;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (FindObjectsOfType<PlatformTexture>().Length > 1) Destroy(gameObject);
    }

    private void TrySetTexture()
    {
        try
        {
            var platform = FindObjectOfType<PlatformRotate>().GetComponent<Renderer>().material;
            platform.mainTexture = textureMaterials[textureIndex];
        }
        catch
        {
            // ignored
        }
    }

    public void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        TrySetTexture();
    }
}