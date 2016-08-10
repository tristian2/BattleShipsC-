using System;
using System.Linq;
using System.Text;
namespace Battleships
{
    public abstract class Ship
    {
        int bowRow;
        int bowColumn;
        int length;
        bool horizontal;
        char symbol;
        bool[] hit = new bool[4];
        bool sunk = false;

        String shipType;

        /**
         * Returns the type of this ship. This method exists only to be overridden, so it doesn't much matter what it returns.
         * @return String shipType
         */
        virtual public String getShipType()
        {
            return this.shipType;
        }
        /**
         * horizontal status -
         * @return bool whether the ship is horizontal or not
         */
        public bool isHorizontal()
        {
            return this.horizontal;
        }
        /**
         * set horizontal status
         * @param bool whether horizontal or not
         */
        void setHorizontal(bool horizontal)
        {
            this.horizontal = horizontal;
        }

        /**
         * get the bow row
         * @return the bow row of the ship
         */
        public int getBowRow()
        {
            return this.bowRow;
        }
        /**
         * set the bow row
         * @param int the bow row of the ship
         */
        public void setBowRow(int row)
        {
            this.bowRow = row;
        }
        /**
         * set the bow column
         * @param the bow column of the ship
         */
        public void setBowColumn(int column)
        {
            this.bowColumn = column;
        }
        /**
         * get the bow column
         * @return the bow column of the ship
         */
        public int getBowColumn()
        {
            return this.bowColumn;
        }

        /**
         * get the length
         * @return int length
         */
        virtual public int getLength()
        {
            return this.length;
        }

        /**
         * is it sunk?
         * @return bool the ship being sunk or not
         */
        virtual public bool isSunk()
        {
            return this.sunk;
        }

        /**
         * sink the ship
         * @param bool set if the ship is sunk or not
         */
        bool setSunk(bool sunk)
        {
            return this.sunk = sunk;
        }

        /**
         * get the array of hits
         * @return bool[] array of the hits made on the ship
         */
        public bool[] getHit()
        {
            return this.hit;
        }

        /**
         * is the ship sunk based on the array of hits?
         * @return bool find out of the ship is sunk
         */
        bool determineIfShipIsSunk()
        {
            int length = this.getLength() - 1;
            sunk = this.hit.All(element => element);// [0..length].every();
            return sunk;
        }

        /**
         * place the show at given row, column and horizontal status
         * @param int the row of the ships bow
         * @param int the column of the ships bow
         * @param bool horizontal?
         * @param Ocean the ocean object
         */
        public void placeShipAt(int row, int column, bool horizontal, Ocean ocean)
        {

            this.setHorizontal(horizontal);

            var placed = false;
            while (!placed)
            {
                var valid = okToPlaceShipAt(row, column, horizontal, ocean);
                if (valid)
                {
                    placeOnBoard(row, column, horizontal, ocean);
                    placed = true;
                }
                else
                {
                    row = ocean.aRandomRow(horizontal, this.getLength());
                    column = ocean.aRandomColumn(horizontal, this.getLength());
                }
            }

        }

        /**
         * is it okay to place the ship based on the constraints at a given location?
         * @param int the row of the ships bow
         * @param int the column of the ships bow
         * @param bool horizontal?
         * @param Ocean the ocean object
         */
        public bool okToPlaceShipAt(int row, int column, bool horizontal, Ocean ocean)
        {
            var valid = true;

            if (ocean.FirstShip)
            {
                ocean.FirstShip = false;
                return valid;
            }

            if (!isEmpty(row, column, horizontal, ocean))
            {
                valid = false;
                return valid;
            }

            Ship[,] ships = ocean.getShipArray();


            for (var i = 0; i < this.getLength(); i++)
            {
                if (horizontal)
                {
                    if (ocean.ships[row,column + i].getShipType() != "EmptySea")
                    {
                        valid = false;
                        return valid;
                    }
                }
                else
                {
                    if (ocean.ships[row + i,column].getShipType() != "EmptySea")
                    {
                        valid = false;
                        return valid;
                    }
                }
            }
            return valid;
        }

        /**
         * check the adjacent squares
         * @param int the row of the ships bow
         * @param int the column of the ships bow
         * @param bool horizontal?
         * @param Ocean the ocean object
         */
        public bool isEmpty(int row, int column, bool horizontal, Ocean ocean)
        {
            Ship[,] ships = ocean.getShipArray();
            int length = this.getLength();
            var empty = true;
            var peekRow = row - 1;
            var peekColumn = column - 1;

            if (horizontal)
            {
                while (peekRow < row + 2)
                {
                    try
                    {
                        while (peekColumn < column + length + 2)
                        {
                            try
                            {
                                if (ships[peekRow,peekColumn].getShipType() != "EmptySea")
                                {
                                    empty = false;
                                }
                                peekColumn++;
                            }
                            catch (IndexOutOfRangeException aoobe)
                            {
                                //might be at the edge, increment anyway
                                peekColumn++;
                            }
                        }
                        peekColumn = column - 1;
                        peekRow++;
                    }
                    catch (IndexOutOfRangeException aoobe)
                    {
                        //might be at the edge, increment anyway
                        peekRow++;
                    }
                }
            }
            else
            {
                //vertical
                while (peekRow < row + length + 1)
                {
                    try
                    {
                        while (peekColumn < column + 2)
                        {
                            try
                            {

                                if (ships[peekRow,peekColumn].getShipType() != "EmptySea")
                                {
                                    empty = false;
                                }
                                peekColumn++;
                            }
                            catch (IndexOutOfRangeException aoobe)
                            {
                                //might be at the edge, increment anyway
                                peekColumn++;
                            }
                        }
                        peekColumn = column - 1;
                        peekRow++;
                    }
                    catch (Exception ex)
                    {
                        //might be at the edge, increment anyway
                        peekRow++;
                    }
                }
            }

            return empty;

        }

        /**
         * place the ship on the board
         * @param int the row of the ships bow
         * @param int the column of the ships bow
         * @param bool horizontal?
         * @param Ocean the ocean object
         */
        public void placeOnBoard(int row, int column, bool horizontal, Ocean ocean)
        {
            Ship[,] ships = ocean.getShipArray();

            this.setBowRow(row);
            this.setBowColumn(column);

            for (var i = 0; i < this.getLength(); i++)
            {
                if (horizontal)
                {
                    ships[row,column + i] = this;
                }
                else
                {
                    ships[row + i,column] = this;
                }
            }
        }

        /**
         * shoot at the ship
         * @param int the row of the shot
         * @param int the column of the shot
         */
        virtual public bool shootAt(int row, int column)
        {
            //if row and column part of ship
            bool directHit = false;

            if (this.horizontal)
            {
                for (int i = 0; i < this.getLength(); i++)
                {
                    if ((this.bowRow == row) && (this.bowColumn + i == column))
                    {
                        directHit = true;
                        this.hit[i] = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.getLength(); i++)
                {
                    if ((this.bowRow + i == row) && (this.bowColumn == column))
                    {
                        directHit = true;
                        this.hit[i] = true;
                    }
                }
            }
            this.setSunk(determineIfShipIsSunk());


            return directHit;
        }
    }
}
