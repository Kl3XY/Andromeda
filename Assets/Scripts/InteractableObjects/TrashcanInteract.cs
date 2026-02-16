using Assets.Scripts.Interfaces;
using Assets.Scripts.Items;
using Assets.Scripts.Player;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.InteractableObjects
{
    internal class TrashcanInteract : MonoBehaviour, IInteractable
    {
        public string Name => "Trashcan";
        private int beingAbleToInteract = 4;
        private bool hasBeenInteracted = false;

        WindowInformation windowInformation;

        public void Interact()
        {
            var finalString = "\nThe Trashcan is empty";
            
            switch (beingAbleToInteract)
            {
                case 4:
                    finalString = "\nYou Look into the Trashcan, its still filled to the brim with... trash.";
                    PlayerStats.Items.Add(new Trash());
                    
                    break;
                case 3:
                    finalString = "\nYou've taken out some trash, you don't know why but it fills you with some self satisfaction";
                    PlayerStats.Items.Add(new Trash());
                    break;
                case 2:
                    finalString = "\nYou... took out more trash. You start to see glimpses of the bottom of the bin.";
                    PlayerStats.Items.Add(new Trash());
                    break;
                case 1:
                    finalString = "\nYou've taken out all trash inside the trashcan. You didnt realize that people were staring at you all the time.\nYou feel... oddly satsified";
                    PlayerStats.Selffulfillment += 1;
                    finalString += "\n\nSelf Fulfillment +1";
                    PlayerStats.Items.Add(new Trash());
                    break;
            }
            beingAbleToInteract--;
            windowInformation.InteractionDescription += finalString;
        }

        public void CreateUI()
        {
            GameObject UI = Resources.Load<GameObject>("InteractionWindow");
            var obj = Instantiate(UI, transform.parent);
            windowInformation = obj.GetComponent<WindowInformation>();
            windowInformation.WindowTitle = "Trashcan";
            windowInformation.ReferenceObject = gameObject;
            Interact();
        }
    }
}
