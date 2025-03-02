using UnityEngine;

namespace _Project.Scripts
{
    public class TeleportBounds : MonoBehaviour
    {
        private Camera _camera;
        private Vector3 _cameraBounds;

        private void Start()
        {
            _camera = Camera.main;
            if (_camera == null)
            {
                enabled = false;
                return;
            }
            _cameraBounds = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _camera.transform.position.z));
        }

        private void LateUpdate()
        {
            if (_camera == null)
                return;

            Vector3 viewPos = transform.position;

            if (viewPos.x > _cameraBounds.x)
                viewPos.x = -_cameraBounds.x;
            if (viewPos.x < -_cameraBounds.x)
                viewPos.x = _cameraBounds.x;
            if (viewPos.y > _cameraBounds.y)
                viewPos.y = -_cameraBounds.y;
            if (viewPos.y < -_cameraBounds.y)
                viewPos.y = _cameraBounds.y;

            transform.position = viewPos;
        }
    }
}
