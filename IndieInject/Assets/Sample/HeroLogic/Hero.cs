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
    [RequireComponent(typeof(Rigidbody))]
    [HelpURL("https://github.com/RimuruDev/IndieInject")]
    [InjectRegion(InjectRegion.Properties)]
    public class Hero : MonoBehaviour
    {
        // === Inject in properties === //
        [Inject] private InputService inputService { get; set; }
        [Inject] private HeroConfig HeroConfig { get; set; }

        private Rigidbody heroRigidbody;

        private void Awake() =>
            heroRigidbody = GetComponent<Rigidbody>();

        private void Update()
        {
            var input = InputService.GetInput();

            var movement = input * (HeroConfig.MoveSpeed * Time.deltaTime);

            heroRigidbody.MovePosition(transform.position + movement);
        }
    }
}