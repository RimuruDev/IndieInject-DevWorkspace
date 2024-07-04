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

using UnityEngine;

namespace IndieInjectSample
{
    [HelpURL("https://github.com/RimuruDev/IndieInject")]
    [CreateAssetMenu(fileName = "HeroConfig", menuName = "Config/HeroConfig")]
    public class HeroConfig : ScriptableObject
    {
        [field: SerializeField] public float MoveSpeed { get; private set; } = 50f;
    }
}