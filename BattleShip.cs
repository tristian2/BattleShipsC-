namespace Battleships {
    class Battleship : Ship
    {

        /**
         * battleship constructor
         */

        public void Battleship()
        {
            length = 4;
            hit = new bool[false, false, false, false];
        }




        /**
         * override the getShipType method
         * @return String indicating the ship type
         */
        [Override]
        String getShipType()
        {
            return "BattleShip";
            }

        /**
         * override the getLength method
         * @return the super class length
         */
        [Override]
        int getLength()
        {
            return super.length;
        }
    }

}
