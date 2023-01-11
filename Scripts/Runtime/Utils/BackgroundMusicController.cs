using System.Collections.Generic;
using Gamekit2D.Runtime.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GOW.Runtime.Runtime.Utils
{
    [RequireComponent(typeof(AudioSource))]
    public class BackgroundMusicController : Singleton<BackgroundMusicController>
    {
        [SerializeField] private ThemeMusic[] music;
        private AudioSource audioSource;

        protected override void Awake()
        {
            base.Awake();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene arg0, LoadSceneMode loadSceneMode)
        {
            audioSource = GetComponent<AudioSource>();
            MusicCheck();
        }

        private void MusicCheck()
        {
            var curIndex = SceneManager.GetActiveScene().buildIndex;
            if (audioSource.isPlaying && !music[curIndex].overrite) return;
            AudioClip clip;

            if (music[curIndex].theme.Contains(audioSource.clip))
            {
                if (!audioSource.isPlaying)
                    audioSource.Play();
                return;
            }

            clip = music[curIndex].GetClip();
            audioSource.clip = clip;
            audioSource.Play();
        }

        [System.Serializable]
        private struct ThemeMusic
        {
            [field: SerializeField] public bool overrite { get; private set; }
            [field: SerializeField] public List<AudioClip> theme { get; private set; }
            public AudioClip GetClip() => theme[Random.Range(0, theme.Count)];
        }
    }
}
