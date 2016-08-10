using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class BattleShipGame
    {
        Ocean ocean;
        //int[] gameHistory = new int[100];
        Stack<String> gameHistory = new Stack<String>(100);            

        public void showWindow()
        {
            play();
            Console.Write(ocean.showBlankBoard());
            Console.Write(ocean.ToString());
                          
            fire(1, 1);
            Console.Write(ocean.ToString());
            fire(8, 1);
            Console.Write(ocean.ToString());
            fire(2, 1);
            Console.Write(ocean.ToString());
            fire(3, 5);
            Console.Write(ocean.ToString());
            fire(9, 1);
            Console.Write(ocean.ToString());
            fire(3, 1);
            Console.Write(ocean.ToString());
            fire(4, 1);
            Console.Write(ocean.ToString());
            fire(6, 1);
            Console.Write(ocean.ToString());
            fire(7, 5);
            Console.Write(ocean.ToString());
            fire(9, 3);
            Console.Write(ocean.ToString());
            fire(1, 3);
            Console.Write(ocean.ToString());
            fire(8, 4);
            Console.Write(ocean.ToString());
            fire(2, 6);
            Console.Write(ocean.ToString());
            fire(3, 9);
            Console.Write(ocean.ToString());
            fire(7, 7);
            Console.Write(ocean.ToString());
            fire(6, 6);
            Console.Write(ocean.ToString());
            fire(5, 5);
            Console.Write(ocean.ToString());
            fire(9, 3);
            Console.Write(ocean.ToString());
            fire(9, 4);
            Console.Write(ocean.ToString());
            fire(9, 1);
            Console.Write(ocean.ToString());
        }

        /**
        * carry out a fire operation, update the various controls depending on the game status
        * @param row of the shot
        * @param column of the shot
        */
        protected void fire(int row, int column)
        {
            ocean.shootAt(row, column);
            updateShips();
    
            if (hasTurnAlreadyBeenPlayed(row, column))
            {
                //swing.status.text = "What? You already fired there!"
                return;
            }

            if (ocean.isGameOver())
            {
                //swing.status.text = "You Won!"
                //swing.score.text = "Ultimate Victory! Fleet sunk!"

                /*if (JOptionPane.showConfirmDialog(swing.mainPanel,
                        "Well done. Wanna another go?",
                        "Confirmation",
                        JOptionPane.YES_NO_OPTION))
                    {
                        exit()
                }
                    else
                    {
                        playAgain()
                    }*/

                return;
            }

            //def classType = ocean.ships[row][column].class.toString()
            /*
            if (classType != "class Battleships.EmptySea") {
                //update window to show the hit!
                swing.status.text = "You hit a ship!"
                swing.score.text = ocean.getShipsSunk() + " ships sunk"
            }
            else {
                swing.status.text = "Loser! You missed"
            }*/
        }

        /**
        *  update the main game panel
        */
        protected void updateShips()
        {
            //println ocean.toString()
            //swing.contents.text = ocean.toString()
        }

        /**
        * locally scoped history of players moves
        * @param row of the shot
        * @param column of the shot
        */
        protected bool hasTurnAlreadyBeenPlayed(int row, int column)
        {            
            //TODO
            if (gameHistory.Contains(row.ToString() + column.ToString()))
            {
                return true;
            }
            else
            {                
                gameHistory.Push(row.ToString() + column.ToString());
                return false;
            }            
        }

        /**
        * start playing - instantiate a new ocean
        */
        protected void play()
        {
            ocean = new Ocean();
            ocean.placeAllShipsRandomly();
            //useful for tracing or cheating!
            //print ocean.ships
        }

        /**
        *   exit the application
        */
        protected void exit()
        {
            //System.exit(0)
        }

        /**
        * reset crucial things such as game history, reset controls
        */
        protected void playAgain()
        {
            ocean = null;
            play();
            initialiseControls();
            //gameHistory[100] = 0;
        }

        /**
        * method to reset all the necessary controls
        */
        protected void initialiseControls()
        {
                /*
            def contents = ocean.showBlankBoard()
                swing.contents.text = ocean.toString()
                swing.status.text = 'Aye Aye Captain!'
                swing.fireStatus.text = 'Ready for orders!'
                swing.score.text = '0 ships sunk'
                swing.row.selectedIndex = 0
                swing.column.selectedIndex = 0
                */
        }

    }
}
