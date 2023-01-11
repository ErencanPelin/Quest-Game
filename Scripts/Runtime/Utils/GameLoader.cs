using Gamekit2D.Runtime.Actor;
using UnityEngine;

namespace GOW.Runtime.Runtime.Utils
{
    public class GameLoader : MonoBehaviour
    {
        [SerializeField] private Transform playerRef;
        [SerializeField] private Transform playerSpawn;
        [SerializeField] private GameObject[] playableHeroes;
        [SerializeField] private bool lvl1;
        
        private void Awake()
        {
            LoadSelectedPlayer();
        }

        private void LoadSelectedPlayer()
        {
            var p = Instantiate(playableHeroes[RuntimeSettings.selectedPlayerIndex], playerSpawn.position, Quaternion.identity);
            var parent = playerRef.parent;
            parent = p.transform;
            playerRef.parent = parent;
            var h = parent.GetComponent<Health>();
            if (lvl1) RuntimeSettings.curHealth = h.curHealth;
            //apply stats:
            h.SetHealth(RuntimeSettings.curHealth);
            playerRef.GetComponent<PlayerRef>().health = h;
            h.onDeath.AddListener(playerRef.GetComponent<PlayerRef>().OnDeath);
        }
    }
}