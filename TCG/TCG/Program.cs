using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Orc orc = new Orc();
            while (true)
            {              
                knight.Attack(orc);
                orc.Attack(knight);
            }
        }
    }
}
