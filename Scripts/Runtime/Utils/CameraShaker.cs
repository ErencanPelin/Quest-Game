using Gamekit2D.Runtime.Effects.SceneEffects;
using UnityEngine;

namespace GOW.Runtime.Runtime.Utils
{
    public class CameraShaker : MonoBehaviour
    {
        private CameraShake camShake;

        private void Awake()
        {
            if (Camera.main != null) camShake = Camera.main.GetComponent<CameraShake>();
        }

        public void Shake() => camShake.Play();
    }
}