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
        ScriptsHelper.TryOrSkip(() =>
        {
            var platform = FindObjectOfType<PlatformRotate>().GetComponent<Renderer>().material;
            platform.mainTexture = textureMaterials[textureIndex];
        });
    }

    public void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        TrySetTexture();
    }
}