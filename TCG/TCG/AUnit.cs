using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
    public abstract class AUnit
    {
        public bool IsAlife = true;
        public string Name { get; set; }
        public string Type { get; set; }// default: mob
        public string Alianse = "Neutral";//Neutral, Enemy, Friend, Human +?
        private int Hp;
        public int Heals
        {
            get
            {
                return Hp;
            }
            set {
                if (Hp <= 0)
                {
                    IsAlife = false;
                    Hp = 0;
                }
                else Hp = value;
            }
        }
        public int MaxHp { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int Lvl { get; set; }
        public int Damage { get; set; }
        public double AttackSpeed { get; set; }
        public int Armor { get; set; }
        public int[] Skills = new int[8];
        public double X { get; set; }
        public double Y { get; set; }
        public int Speed { get; set; }
        public double RangeAttack { get; set; }//Melee - 10, Range - 80

        public AUnit()
        {
            Name = "Unit";
            Type = "Mob";
            Alianse = "Neutral";
            Heals = 1;
            MaxHp = 1;
            Mana = 1;
            MaxMana = 1;
            Lvl = 1;
            Damage = 1;
            AttackSpeed = 1;
            Armor = 1;
            X = 10;
            Y = 10;
            Speed = 10;
            RangeAttack = 10;
        }
        public AUnit(string name, string type, string alianse, int hp, int mxhp,int mana, int mxmana, int lvl, int damage, double ac, int armor, int[] skills, double x, double y, int speed, double range)
        {
            Name = name;
            Type = type;
            Alianse = alianse;
            Heals = hp;
            MaxHp = mxhp;
            Mana = mana;
            MaxMana = mxmana;
            Lvl = lvl;
            Damage = damage;
            AttackSpeed = ac;
            Armor = armor;
            Skills = skills;
            X = x;
            Y = y;
            Speed = speed;
            RangeAttack = range;
        }
        public void Move(double x, double y)
        {
            if (X < x + Speed && Y < y + Speed && X < x - Speed && Y < y - Speed)
            {
                X += Speed;
                Y += Speed;
                Move(x, y);
            }
            else if (X > x + Speed && Y > y + Speed && X > x - Speed && Y > y - Speed)
            {

                X -= Speed;
                Y -= Speed;
                Move(x, y);
            }
            else if (X < x + Speed && Y > y + Speed && X < x - Speed && Y > y - Speed)
            {

                X += Speed;
                Y -= Speed;
                Move(x, y);
            }
            else if (X > x + Speed && Y < y + Speed && X > x - Speed && Y < y - Speed)
            {

                X -= Speed;
                Y += Speed;
                Move(x, y);
            }
        }
        public void Attack(AUnit target)
        {
            if(target.X <= RangeAttack+X && target.X >= RangeAttack - X && target.Y <= RangeAttack + Y && target.Y >= RangeAttack - Y)
            {
                target.Heals -= (Damage - target.Armor);
            }
        }
    }
}
