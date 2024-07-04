// **************************************************************** //
//
//   Copyright (c) RimuruDev, YUJECK. All rights reserved.
//   Contact us:
//          - RimuruDev: 
//              - Gmail:    rimuru.dev@gmail.com
//              - LinkedIn: https://www.linkedin.com/in/rimuru/
//              - GitHub:   https://github.com/RimuruDev
//          - YUJECK:
//              - GitHub:   https://github.com/YUJECK
//
//   This project is licensed under the MIT License.
//   See the LICENSE file in the project root for more information.
//
// **************************************************************** //

using IndieInject;
using UnityEngine;

namespace IndieInjectSample
{
    [SelectionBase]
    [DisallowMultipleComponent]
    [HelpURL("https://github.com/RimuruDev/IndieInject")]
    public sealed class HeroDataProvider : MonoProvider
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private Transform rootTransformForHero;
        [SerializeField] private HeroConfig heroConfig;

        [Provide(true)]
        public GameObject ProvidePlayerPrefab() => playerPrefab;

        [Provide(true)]
        public HeroConfig ProvidePlayerConfig() => heroConfig;

        [Provide(true)]
        public Transform RootTransformForHero() => rootTransformForHero;

        [System.Diagnostics.Conditional("UNITY_EDITOR")]
        private void OnValidate()
        {
            // Just in case someone loses their links when they download the example, an attempt will be made to restore them. //

            if (playerPrefab == null)
                playerPrefab = Resources.Load<GameObject>(AssetPath.HeroPrefab);

            if (heroConfig == null)
                heroConfig = Resources.Load<HeroConfig>(AssetPath.HeroConfig);

            if (rootTransformForHero != null)
                return;

            rootTransformForHero = GameObject.Find(Const.ParentForRuntimeObj)?.transform;

            if (rootTransformForHero == null)
                rootTransformForHero = new GameObject(Const.ParentForRuntimeObj).transform;
        }
    }
}