using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Battleship : Ship
    {

        /**
         * battleship constructor
         */

        public Battleship()
        {
            int length = 4;
            bool[] hit = new bool[length];
        }

        /**
         * override the getShipType method
         * @return String indicating the ship type
         */
        public override String getShipType()
        {
            return "BattleShip";
         }

        /**
         * override the getLength method
         * @return the super class length
         */
        public override int getLength()
        {
            return base.getLength();
        }
    }

}
