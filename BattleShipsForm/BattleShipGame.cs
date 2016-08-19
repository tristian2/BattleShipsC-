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
            //initialiseControls();
            /*
            Console.Write(ocean.showBlankBoard());
            Console.Write(ocean.ToString());
            test for (var i = 0; i < 10; i++)
                for (var j = 0; j < 10; j++)
                    fire(i, j);
            Console.Write(ocean.showBlankBoard());
            Console.Write(ocean.ToString());*/

            

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
                Console.Write("What? You already fired there!");
                return;
            }

            if (ocean.isGameOver())
            {
                //swing.status.text = "You Won!"
                //swing.score.text = "Ultimate Victory! Fleet sunk!"
                Console.Write("You Won!");
                Console.Write("Ultimate Victory! Fleet sunk!");

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

            Console.Write(ocean.ships[row,column]);
            Console.Write(ocean.ships[row, column]);

            var classType = ocean.ships[row, column].GetType().Name;
            
            if (classType != "EmptySea") {
                //update window to show the hit!
                Console.Write("You hit a ship!");
                Console.Write(ocean.getShipsSunk() + " ships sunk");
            }
            else {
                Console.Write("Loser! You missed");
            }
        }

        /**
        *  update the main game panel
        */
        protected void updateShips()
        {
            Console.Write(ocean.ToString());
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
            Console.WriteLine(ocean.ships);
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
