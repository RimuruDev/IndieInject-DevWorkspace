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
    public class InputService
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        public static Vector3 GetInput()
        {
            var horizontal = Input.GetAxis(Horizontal);
            var vertical = Input.GetAxis(Vertical);

            return new Vector3(horizontal, 0, vertical);
        }
    }
}