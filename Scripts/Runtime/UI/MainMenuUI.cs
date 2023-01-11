using Gamekit2D.Runtime.Utils;
using UnityEngine;

namespace GOW.Runtime.UI
{
    public class MainMenuUI : MonoBehaviour
    {
        public void Play() => Scenes.LoadScene("PlayerSelect");
        public void How2Play() => Scenes.LoadScene("How2Play");
        public void Settings() => Scenes.LoadScene("Settings");
        public void Credits() => Scenes.LoadScene("Credits");
        public void Back() => Scenes.LoadScene("MainMenu");
        public void OpenURL(string url) => Application.OpenURL(url);
    }
}
