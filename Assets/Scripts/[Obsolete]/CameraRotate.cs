using UnityEngine;

namespace ObsoleteScripts
{
    [System.Obsolete]
    public class CameraRotate : MonoBehaviour
    {
        [SerializeField] private Vector3 rotateVector;
        private Transform _camera;

        private void Start()
        {
            _camera = Camera.main.transform;
        }

        private void Update()
        {
            _camera.Rotate(rotateVector * Time.deltaTime);
        }
    }
}
