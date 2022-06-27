using System;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public event Action<PlatformSize> PlatformResize;

    public void Setup(PlatformSize size)
    {
        PlatformResize?.Invoke(size);
    }
}
