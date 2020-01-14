using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
    class Human : AUnit
    {
        public Human()
        {
            Alianse = "Human";
            Lvl = 1;
        }
    }

    class Knight : Human//Melee
    {
        public Knight()
        {
            Name = "KnightName";
            Type = "Knight";
            MaxHp = 250;
            Heals = MaxHp;
            MaxMana = 20;
            Mana = MaxMana;
            Damage = 30;
            Armor = 10;         
        }
    }

    class Arrows : Human//Range
    {
        public Arrows()
        {
            Name = "ArrowsName";
            Type = "Arrows";
            MaxHp = 150;
            Heals = MaxHp;
            MaxMana = 50;
            Mana = MaxMana;
            Damage = 50;
            Armor = 5;
        }
    }
}
