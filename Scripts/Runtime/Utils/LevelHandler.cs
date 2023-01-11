using UnityEngine;

namespace GOW.Runtime.Runtime.Utils
{
    public class LevelHandler : MonoBehaviour
    {
        public void NextLevel() => RuntimeSettings.curLevel++;
    }
}