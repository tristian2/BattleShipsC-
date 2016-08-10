using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Destroyer : Ship
    {

        /**
         * Destroyer constructor
         */

        public Destroyer()
        {
            int length = 2;
            bool[] hit = new bool[length];
        }
        /**
        * override the toString method
        * @return String indicating the ship
        */
        public override String ToString()
        {
            return "D";
        }

        /**
         * override the getShipType method
         * @return String indicating the ship type
         */
        public override String getShipType()
        {
            return "Destroyer";
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
