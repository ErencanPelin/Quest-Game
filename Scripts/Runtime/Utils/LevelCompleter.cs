using Gamekit2D.Runtime.LevelTiles;
using UnityEngine;
using UnityEngine.Events;

namespace GOW.Runtime.Runtime.Utils
{
    public class LevelCompleter : MonoBehaviour
    {
        [SerializeField] private LevelExit levelExit;
        [SerializeField] private UnityEvent onComplete;
        private int enemiesRemaining;

        private void Awake()
        {
            enemiesRemaining = transform.childCount;
        }

        public void NegateEnemy()
        {
            enemiesRemaining--;
            if (enemiesRemaining is not 0) return;
            levelExit.gameObject.SetActive(true);
            onComplete.Invoke();
        }
    }
}