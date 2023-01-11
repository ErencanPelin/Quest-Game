using System;
using GOW.Runtime.Runtime.Utils;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace GOW.Runtime.UI
{
    public class SettingsUI : MonoBehaviour
    {
        [SerializeField] private AudioMixer mixer;
        [SerializeField] private Slider audioSlider;

        private void Awake()
        {
            audioSlider.value = RuntimeSettings.volume;
        }

        public void ChangeVolume(Slider slider)
        {
            RuntimeSettings.volume = slider.value;
            mixer.SetFloat("MasterVolume", slider.value);
        }
    }
}
