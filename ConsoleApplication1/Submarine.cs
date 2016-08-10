using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Submarine : Ship
    {

        /**
         * Submarine constructor
         */

        public Submarine()
        {
            int length = 1;
            bool[] hit = new bool[length];
        }
        /**
        * override the toString method
        * @return String indicating the ship
        */
        public override String ToString()
        {
            return "S";
        }

        /**
         * override the getShipType method
         * @return String indicating the ship type
         */
        public override String getShipType()
        {
            return "Submarine";
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
