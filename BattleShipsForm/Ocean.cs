using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Ocean
    {
        int upperBoardBound = 10;
        public Ship[,] ships = new Ship[10,10]; // Used to quickly determine which ship is in any given location.

        //Ocean ocean;
        bool firstShip;  //is it the first ship
        int shotsFired;  //-- The total number of shots fired by the user.
        int hitCount; //-- The number of times a shot hit a ship. If the user shoots the same part of a ship more than once, every hit is counted, even though the additional "hits" don't do the user any good.
        int shipsSunk; //-- The number of ships sunk (10 ships in all).

        //the fleet - declared in this scope so they are available
        Battleship battleship = new Battleship();
        Cruiser cruiser1 = new Cruiser();
        Cruiser cruiser2 = new Cruiser();
        Destroyer destroyer1 = new Destroyer();
        Destroyer destroyer2 = new Destroyer();
        Destroyer destroyer3 = new Destroyer();
        Submarine submarine1 = new Submarine();
        Submarine submarine2 = new Submarine();
        Submarine submarine3 = new Submarine();
        Submarine submarine4 = new Submarine();

        public bool FirstShip
        {
            get
            {
                return firstShip;
            }

            set
            {
                firstShip = value;
            }
        }

        /**
         * The constructor. Creates an "empty" ocean (fills the ships array with EmptySeas).
         * Also initializes any game variables, such as how many shots have been fired.
         */
        public Ocean()
        {
            firstShip = true;
            shotsFired = 0;
            shipsSunk = 0;
            hitCount = 0;
            this.assignEmptySeaIndicesToShipArray();
        }

        /**
         *  the place on the board occupied
         * @param the row
         * @param the column
         * @return String the ship type
         */
        bool isOccupied(int row, int column)
        {
            return ships[row,column].getShipType() != "EmptySea";
        }

        /**
         * Returns the number of shots fired (in this game).
         * @return int the total number of shots fired in a given game
         */
        int getShotsFired()
        {
            return this.shotsFired;
        }
        /**
         * increments the shots fired in the game count
         */
        void setShotsFired()
        {
            this.shotsFired++;
        }
        /**
         * Returns the number of hits recorded (in this game). All hits are counted, not just the first time a given square is hit.
         * @return int the number of hits made in a game
         */
        int getHitCount()
        {
            return this.hitCount;
        }
        /**
         * Returns the number of ships sunk (in this game).
         * return int the number of ships that have been sunk
         */
        public int getShipsSunk()
        {
            //TODO
            //int shipsSunk = 1;
            
            ShipComparator shipComparator = new ShipComparator();
            //var uniqueShips = ships.SelectMany(x=>x).ToArray().Distinct();
            var uniqueShips = ships.Cast<Ship>().ToList();
            int shipsSunk = 0;

            //uniqueShips.Select(x=>x.symb).Distinct().ForEach( x=> { if (x.isSunk()) { shipsSunk++; } });
            uniqueShips.Select(x=>x).Distinct().ToList().ForEach( x => { if (x.isSunk()) { shipsSunk++; } });//




            return shipsSunk;
        }
        /**
         * Returns true if all ships have been sunk, otherwise false.
         * return whether the game is over or not
         */
        public bool isGameOver()
        {
            var gameOver = false;
            if (this.getShipsSunk() == 10)
                gameOver = true;
            return gameOver;
        }
        /**
         * Returns the 10x10 array of ships. The methods in the Ship class that take an Ocean parameter really need to be able
         * to look at the contents of this array; the placeShipAt method even needs to modify it. While it is undesirable to
         * allow methods in one class to directly access instance variables in another class, sometimes there is just no good alternative.
         * @return Ship[][] the ships array
         */
        public Ship[,] getShipArray()
        {
            return this.ships;
        }

        /**
         * override the tioString() method
         * Returns a String for printing the ocean. To aid the user, row numbers should be displayed along the left edge of the array,
         * and column numbers should be displayed along the top. Numbers should be 0 to 9, not 1 to 10. The top left corner square
         * should be 0, 0. Use 'S' to indicate a location that you have fired upon and hit a (real) ship, '-' to indicate a location
         * that you have fired upon and found nothing there, 'x' to indication location containing a sunken ship, and '.' to indicate
         * a location that you have never fired upon.  This is the only method in the Ocean class that does any input/output, and it
         * is never called from within the Ocean class (except possibly during debugging), only from the BattleshipGame class.
         * @return the formatted board
         */        
        public override String ToString()
        {
            return this.formatBoardForConsole();
        }

        /**
         * returns a random column integer
         * @return var a random column
         */
        public int aRandomColumn(bool horizontal, int length)
        {

            var randomColumn = new Random();
            int randomInt;
            if (horizontal)
            {
                randomInt = randomColumn.Next(upperBoardBound - length);
        }
            else
            {
                randomInt = randomColumn.Next(upperBoardBound);
            }
            return randomInt;
        }

        /**
         * returns a random row integer
         * @return var a random row
         */
        public int aRandomRow(bool horizontal, int length)
        {

            var randomRow = new Random();
            int randomInt;
            if (horizontal)
            {
                randomInt = randomRow.Next(upperBoardBound);
        }
            else
            {
                randomInt = randomRow.Next(upperBoardBound - length);
            }
            return randomInt;
        }

        /**
         * returns a random bool
         * @return var random true or false
         */
        private bool aRandombool()
        {
            var rnd = new Random();
            return rnd.NextDouble() >=.5;
        }

        /**
         * Place all ten ships randomly on the (initially empty) ocean.
         * Place larger ships before smaller ones, or you may end up with no legal place to put a large ship.
         * You will want to use the Random class in the java.util package, so look that up in the Java API.
         * */
        public void placeAllShipsRandomly()
        {
            int row = 0;
            int column = 0;
            //var ships = new string[] { "battleship", "cruiser", "destroyer", "submarine" };
            String[] shipTypes = new String[] { "battleship", "cruiser", "destroyer", "submarine" };

            foreach (String s in shipTypes)
            {
                bool horizontal;
                Console.WriteLine(s);                               
                //heuristic: position larger ships first
                switch (s)
                {
                    case "battleship":
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, battleship.getLength());
                        column = this.aRandomColumn(horizontal, battleship.getLength());
                        battleship.placeShipAt(row, column, horizontal, this);
                        break;
                    case "cruiser":
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, cruiser1.getLength());
                        column = this.aRandomColumn(horizontal, cruiser1.getLength());
                        cruiser1.placeShipAt(row, column, horizontal, this);
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, cruiser2.getLength());
                        column = this.aRandomColumn(horizontal, cruiser2.getLength());
                        cruiser2.placeShipAt(row, column, horizontal, this);
                        break;
                    case "destroyer":
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, destroyer1.getLength());
                        column = this.aRandomColumn(horizontal, destroyer1.getLength());
                        destroyer1.placeShipAt(row, column, horizontal, this);
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, destroyer2.getLength());
                        column = this.aRandomColumn(horizontal, destroyer2.getLength());
                        destroyer2.placeShipAt(row, column, horizontal, this);
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, destroyer3.getLength());
                        column = this.aRandomColumn(horizontal, destroyer3.getLength());
                        destroyer3.placeShipAt(row, column, horizontal, this);
                        break;
                    case "submarine":
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, submarine1.getLength());
                        column = this.aRandomColumn(horizontal, submarine1.getLength());
                        submarine1.placeShipAt(row, column, horizontal, this);
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, submarine2.getLength());
                        column = this.aRandomColumn(horizontal, submarine2.getLength());
                        submarine2.placeShipAt(row, column, horizontal, this);
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, submarine3.getLength());
                        column = this.aRandomColumn(horizontal, submarine3.getLength());
                        submarine3.placeShipAt(row, column, horizontal, this);
                        horizontal = this.aRandombool();
                        row = this.aRandomRow(horizontal, submarine4.getLength());
                        column = this.aRandomColumn(horizontal, submarine4.getLength());
                        submarine4.placeShipAt(row, column, horizontal, this);
                        break;
                    }
            }

        }

        /**
         * initialise the array with empty seas
         */
        private void assignEmptySeaIndicesToShipArray()
        {
            for (int row = 0; row < ships.GetLength(0); row++)
            {                
                for (int col = 0; col < ships.GetLength(1); col++)
                {
                    if (ships[row, col] == null)
                    {
                        var emptysea = new EmptySea();
                        placeOnBoard(row, col, emptysea);
                    }
                }                
            }
        }

        /**
         *  format the board historically for console, but also used by swing GUI
         * @return String the formatted board
         */
        private String formatBoardForConsole()
        {

            var e = Encoding.GetEncoding("unicode");
            char c = '\u2551';
            var s = c.ToString();

            //replace this with (for row 0 ) -+ and \n
            //for second row  them | then then the  symbol finally \n

            StringBuilder sb1 = new StringBuilder();
            sb1.Append(" 0 1 2 3 4 5 6 7 8 9 \n");
            for (int row = 0; row < ships.GetLength(0); row++)
            {
                sb1.Append(s);
                for (int col = 0; col < ships.GetLength(1); col++)
                {
                    Ship ship = ships[row, col];
                    sb1.Append(this.getSymbolForShipState(ship, row, col)+ c.ToString());
                    //sb1.Append("-");
                }
                //sb1.Append("|\n");
            }
            sb1.Append('\u2551'.ToString() + '\u2551'.ToString() +   "\n");
            return sb1.ToString();
        }

        /**
         * get the relevant symbol for the ship state
         * @param Ship
         * @param int the row
         * @param int the column
         * @return String the relevant symbol for the ship depending on its state
         */
        private String getSymbolForShipState(Ship ship, int row, int col)
        {
            String replacementSymbolFragment = ".";    
            if (ship.getShipType() == "EmptySea")
                {    //is it emptysea? is it hit?  then show - no? then show .
                if (((EmptySea)ship).getFiredAt())
                    replacementSymbolFragment = "-";
                else
                    replacementSymbolFragment = ".";
            }
            else
            { //must be a ship
                if (ship.isHorizontal())
                { //check row col subtract bowcol from col, get index from hit array, is it true? show x
                    bool[] hit = ship.getHit();
                    if (hit[col - ship.getBowColumn()])
                        replacementSymbolFragment = "x";
                }
                if (!ship.isHorizontal())
                { //it's vertical
                    bool[] hit = ship.getHit();
                    if (hit[row - ship.getBowRow()])
                        replacementSymbolFragment = "x";
                }
                if (ship.isSunk())
                {
                    replacementSymbolFragment = "S";
                }

            }
            return replacementSymbolFragment;
        }

        /**
         * generate a "blank" board
         * @return String of the blank board
         */
        public String showBlankBoard()
        {
            StringBuilder sb1 = new StringBuilder();
            foreach (int index in Enumerable.Range(1, 10))
            {
                sb1.Append("+-+-+-+-+-+-+-+-+-+-+\n");
                sb1.Append("| | | | | | | | | | |\n");
            }
            sb1.Append("+-+-+-+-+-+-+-+-+-+-+");            
            return sb1.ToString();    
        }

        /**
         * now place ships on the playing board
         * @param int the row
         * @param int the column
         * @param Ship a ship
         */
        private void placeOnBoard(int row, int column, Ship ship)
        {
            ship.setBowRow(row);
            ship.setBowColumn(column);
            ships[row, column] = ship;
        }

        /**
         * Returns true if the given location contains a "real" ship, still afloat, (not an EmptySea), false if it does not.
         * In addition, this method updates the number of shots that have been fired, and the number of hits.
         * Note: If a location contains a "real" ship, shootAt should return true every time the user shoots at that same location.
         * Once a ship has been "sunk", additional shots at its location should return false.
         * @param int a row
         * @param int a column
         * @return bool whether there has been a hit
         */
        public bool shootAt(int row, int column)
        {
            bool hit = false;
            this.setShotsFired();
            Ship ship = ships[row,column];
    
            if (isOccupied(row, column))
            {
                if (!ship.isSunk())
                {
                    hit = ship.shootAt(row, column);
                    this.hitCount++;
                }
                else
                {
                    hit = false;
                }
            }
            else
            {  //assume its an empty sea
                if (ship.getShipType() == "EmptySea")
                {
                    ((EmptySea)ship).setFiredAt();
                }
            }

            return hit;
        }
    }
}




