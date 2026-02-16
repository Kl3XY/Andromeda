using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Player
{
    static class PlayerStats
    {
        public static List<IItem> Items = new();
        public static int Strength = 0;
        public static int Intelligence = 0;
        public static int Dexterity = 0;
        public static int Selffulfillment = 0;
        public static int Health = 100;
        public static int Ram = 0;
    }
}
