using System;
using Gamekit2D.Runtime.Actor;
using UnityEngine;
using UnityEngine.Events;

namespace GOW.Runtime.Runtime.Utils
{
    public class PlayerRef : MonoBehaviour
    {
        [SerializeField] private UnityEvent onPlayerDeath;
        [SerializeField] private Animator lowHealthAnim;
        private static readonly int LowHeath = Animator.StringToHash("LowHealth");

        public Health health { get; set; }
        
        public void AddHealth(float value) => health.AddHealth(value);
        public void OnDeath() => onPlayerDeath.Invoke();

        private void Update()
        {
            lowHealthAnim.SetBool(LowHeath, health.curHealth <= 35);
        }
    }
}