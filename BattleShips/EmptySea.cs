using System;
using System.Linq;
using System.Text;

namespace Battleships {
    class EmptySea : Ship
    {
        bool firedAt; 
        /**
         * Cruiser constructor
         */

        public EmptySea()
        {
            firedAt = false;
        }
        /**
         * set fired at status, used by the ocean board to denote symbol shown
         */
        public bool setFiredAt()
        {
            return this.firedAt = true;
        }

        /**
         * override the getLength method
         * @return def fired at?
         */
        public bool getFiredAt()
        {
            return this.firedAt;
        }

        /**
         * override the toString method
         * @return String indicating the ship
         */        
        public override String ToString()
        {
            return "E";
        }

        /**
         * override the getShipType method
         * @return String indicating the ship type
         */        
        public override String getShipType()
        {
            return "EmptySea";
        }

        /**
         * override shootat the ship method so that it always returns false
         * @param row of the shot
         * @param column of the shot
         * @return false
         */        
        public override bool shootAt(int row, int column)
        {
            return false;
        }

        /**
         * override isSunk method so that it always returns false
         * @return false
         */        
        public override bool isSunk()
        {
            return false;
        }

    }

}
