using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Cruiser : Ship
    {
        int length;
        /**
         * Cruiser constructor
         */
        
        public Cruiser()
        {
            this.length = 3;
            hit = new bool[this.length];
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
            return this.length;
        }
    }

}
