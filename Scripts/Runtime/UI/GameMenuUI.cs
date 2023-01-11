using Gamekit2D.Runtime.Utils;
using UnityEngine;

namespace GOW.Runtime.UI
{
    public class GameMenuUI : MonoBehaviour
    {
        public void BackToMenu() => Scenes.LoadScene("MainMenu");
    }
}