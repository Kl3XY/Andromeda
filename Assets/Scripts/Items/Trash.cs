using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Items
{
    internal class Trash : IItem
    {
        public string Name => "Trash";

        public string Description => "Trash, from a trashcan.\n\nYou can't even discern what you are holding.";
    }
}
