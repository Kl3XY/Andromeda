using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.UI
{
    internal class BasicWindowBehaviour : MonoBehaviour
    {
        private void Start()
        {
            transform.position = Mouse.current.position.ReadValue();
        }
    }
}
