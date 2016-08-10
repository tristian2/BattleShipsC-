using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Cruiser : Ship
    {

        /**
         * Cruiser constructor
         */

        public Cruiser()
        {
            int length = 3;
            bool[] hit = new bool[length];
        }
        /**
        * override the toString method
        * @return String indicating the ship
        */
        public override String ToString()
        {
            return "C";
        }

        /**
         * override the getShipType method
         * @return String indicating the ship type
         */
        public override String getShipType()
        {
            return "Cruiser";
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
