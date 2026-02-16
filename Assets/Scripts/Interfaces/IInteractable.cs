using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    internal interface IInteractable
    {
        public abstract string Name { get; }

        public abstract void CreateUI();
        public abstract void Interact();
    }
}
