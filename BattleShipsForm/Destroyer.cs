using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Destroyer : Ship
    {
        int length;
        /**
         * Destroyer constructor
         */
        public Destroyer()
        {
            this.length = 2;
            hit = new bool[this.length];
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
            return this.length;
        }
    }

}
