using Gamekit2D.Runtime.Utils;
using GOW.Runtime.Runtime.Utils;
using UnityEngine;

namespace GOW.Runtime.UI
{
    public class PlayerSelectUI : MonoBehaviour
    {
        public void SelectPlayer(int index)
        {
            //select player
            RuntimeSettings.selectedPlayerIndex = index;
            Scenes.LoadScene("Level1");
        }

        public void BackToMenu()
        {
            Scenes.LoadScene("MainMenu");
        }
    }
}
