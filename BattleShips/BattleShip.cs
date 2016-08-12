using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Battleship : Ship
    {

        /**
         * battleship constructor
         */
        int length;

        public Battleship()
        {
            this.length = 4;
            hit = new bool[this.length];
        }
        /**
        * override the toString method
        * @return String indicating the ship
        */
        public override String ToString()
        {
            return "B";
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
            return this.length;
        }
    }

}
