using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
    class Orcs : AUnit
    {
        public Orcs()
        {
            Alianse = "Orcs";
            Lvl = 1;
        }
    }

    class Orc : Orcs//Melee
    {
        public Orc()
        {
            Name = "OrcName";
            Type = "Orc";
            MaxHp = 350;
            Heals = MaxHp;
            MaxMana = 10;
            Mana = MaxMana;
            Damage = 40;
            Armor = 2;
        }
    }

    class Berserker : Orcs
    {
        public Berserker()
        {
            Name = "BerserkerName";
            Type = "Berserker";
            MaxHp = 550;
            Heals = MaxHp;
            MaxMana = 5;
            Mana = MaxMana;
            Damage = 60;
            Armor = 0;
        }
    }
}
