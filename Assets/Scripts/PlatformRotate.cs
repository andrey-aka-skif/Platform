using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public int mode;
    [SerializeField] private Vector3 rotateVectorFactor;
    [SerializeField] private Accelerometer accelerometer;
    [SerializeField] private int maxRotate = 20;

    private float _scale = 1;

    private Transform _transform;

    private void Awake()
    {
        mode = SettingsData.mode;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        _transform = transform;

        _scale = mode switch
        {
            0 => 1.2f,
            1 => 1,
            _ => 0.8f
        };
        print(_scale + " - " + mode);

        var localScale = _transform.localScale;
        localScale = new Vector3(localScale.x * _scale, 0.5f, localScale.z * _scale);
        _transform.localScale = localScale;
    }

    private void Update()
    {
        var vec = new Vector3(accelerometer.AccelerometerVector3.z, 0, 0);
        vec = Vector3.Scale(vec, rotateVectorFactor);
        _transform.Rotate(vec);

        vec = _transform.rotation.eulerAngles;

        if (vec.x < 180 && vec.x > maxRotate) vec.x = maxRotate;
        if (vec.x > 180 && vec.x < 360 - maxRotate) vec.x = 360 - maxRotate;

        if (mode == 2)
        {
            if (vec.z < 180 && vec.z > maxRotate) vec.z = maxRotate;
            if (vec.z > 180 && vec.z < 360 - maxRotate) vec.z = 360 - maxRotate;
        }
        else vec.z = 0f;

        vec.y = -45;

        _transform.rotation = Quaternion.Euler(vec);
    }
}