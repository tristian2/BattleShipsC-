//#define DEBUG
#define RELEASE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleShipGame battleshipGame = new BattleShipGame();
            battleshipGame.showWindow();


            #if DEBUG
            Console.WriteLine("DEBUG is defined");
            #else
                Console.WriteLine("DEBUG is not defined");
            #endif
            Console.Read();
        }
    }
}
