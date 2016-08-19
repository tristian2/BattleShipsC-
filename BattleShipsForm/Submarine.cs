using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class Submarine : Ship
    {        
        int length;
        
        /**
         * Submarine constructor
         */
        public Submarine()
        {
            length = 1;
            hit = new bool[this.length];
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
            return this.length;
        }
    }
}
