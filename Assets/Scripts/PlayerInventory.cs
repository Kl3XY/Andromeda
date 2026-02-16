using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal class PlayerInventory : IContainer
    {
        public List<IItem> Items => new List<IItem>();
    }
}
