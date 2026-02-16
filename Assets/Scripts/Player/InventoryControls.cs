using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Player
{
    internal class InventoryControls : MonoBehaviour
    {
        [SerializeField] GameObject Inventory;
        InputAction inventoryToggle;
        bool isInventoryToggled
        {
            get {  return toggle; }
            set
            {
                toggle = value;
                Inventory.gameObject.SetActive(toggle);
            }
        }
        bool toggle = false;
        private void Start()
        {
            inventoryToggle = InputSystem.actions.FindAction("Inventory");
        }
        private void Update()
        {
            if (inventoryToggle.WasPressedThisFrame()) { 
                isInventoryToggled = !isInventoryToggled;
            }
        }
    }
}
