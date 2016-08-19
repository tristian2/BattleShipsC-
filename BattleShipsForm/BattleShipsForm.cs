using Battleships;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class BattleShipsForm : Form
    {

        Ocean ocean;
        //int[] gameHistory = new int[100];
        Stack<String> gameHistory = new Stack<String>(100);

        

        public BattleShipsForm()
        {
            play();
            InitializeComponent();       
                 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Fire_Click(object sender, EventArgs e)
        {
            fire(Convert.ToInt16(cboRow.Text), Convert.ToInt16(cboCol.Text));
            fireStatusPanel.Text = "Fired at Row:" + cboRow.SelectedItem + " Column:" + cboCol.SelectedItem;
        }

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
                statusPanel.Text = "What? You already fired there!";
                Console.Write("What? You already fired there!");
                return;
            }

            if (ocean.isGameOver())
            {
                statusPanel.Text = "You Won!";
                scorePanel.Text = "Ultimate Victory! Fleet sunk!";
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

            Console.Write(ocean.ships[row, column]);
            Console.Write(ocean.ships[row, column]);

            var classType = ocean.ships[row, column].GetType().Name;

            if (classType != "EmptySea")
            {
                //update window to show the hit!
                Console.Write("You hit a ship!");
                Console.Write(ocean.getShipsSunk() + " ships sunk");
            }
            else
            {
                Console.Write("Loser! You missed");
            }
        }

        /**
        *  update the main game panel
        */
        protected void updateShips()
        {
            Console.Write(ocean.ToString());
            mainPanel.Text = ocean.ToString();
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
