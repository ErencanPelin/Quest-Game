using Gamekit2D.Runtime.Actor;
using UnityEngine;

namespace GOW.Runtime.Runtime.Utils
{
    public class PlayerStats : MonoBehaviour
    {
        public void Save()
        {
            RuntimeSettings.curHealth = transform.parent.GetComponent<Health>().curHealth;
        }
    }
}