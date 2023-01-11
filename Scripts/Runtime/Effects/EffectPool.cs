using UnityEngine;

namespace GOW.Runtime.Runtime.Effects
{
    public class EffectPool : MonoBehaviour
    {
        [SerializeField] private GameObject effectPrefab;
        [SerializeField] private int maxEffects;
        private static GameObject[] activeEffects;
        private static int activeNum;

        protected void Awake()
        {
            activeEffects = new GameObject[maxEffects];
            for (var i = 0; i < maxEffects; i++) //create pool
            {
                activeEffects[i] = Instantiate(effectPrefab, Vector2.zero, Quaternion.identity, transform);
                activeEffects[i].SetActive(false);
            }
        }

        public static void SpawnEffect(Vector2 position)
        {
            activeEffects[activeNum].transform.position = position;
            activeEffects[activeNum].SetActive(true);
            activeNum++;
            if (activeNum >= activeEffects.Length) activeNum = 0;
        }
    }
}