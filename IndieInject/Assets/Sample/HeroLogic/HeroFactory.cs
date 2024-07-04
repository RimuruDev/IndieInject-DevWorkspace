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
    [HelpURL("https://github.com/RimuruDev/IndieInject")]
    public class HeroFactory : MonoBehaviour
    {
        // === Inject in field === //
        [Inject] private GameObject playerPrefab;
        private Transform rootTransform;

        // === Inject in method === //
        [Inject]
        private void Constructor(Transform rootTransformForSpawnHero)
        {
            rootTransform = rootTransformForSpawnHero;
        }

        private void Start()
        {
            // === Instantiate + Inject in new GameObject === //
            Indie.Fabric.Instantiate(playerPrefab, rootTransform);
        }
    }
}