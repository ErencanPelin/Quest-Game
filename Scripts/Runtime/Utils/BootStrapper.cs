using UnityEngine;

namespace GOW.Runtime.Runtime.Utils
{
    internal static class BootStrapper
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Awake()
            => Object.Instantiate(Resources.Load<GameObject>("BGM"));
    }
}