using UnityEngine;

namespace GOW.Runtime.Runtime.Effects
{
    public class EffectPoolHandler : MonoBehaviour
    {
        public void SpawnEffect() => EffectPool.SpawnEffect(transform.position);
    }
}