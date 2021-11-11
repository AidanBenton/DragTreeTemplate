using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        // TODO - create an int variable to track currentRow,
        int currentRow = 0; 
        // TODO - create a Stopwatch object called stopwatch 
        Stopwatch myWatch = new Stopwatch();
        // TODO - create a timer on the form called lightTimer (interval 400ms)
        // TODO - create the tick event for the lightTimer

        // place the following comments in the lighTimer tick event
        // TODO - create a switch block that checks currentRow. In each case
        // it will light up the appropriate lights, (labels). 

        // TODO - increment the currentRow value by 1

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO - start the timer
            currentRow = 1;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch
            myWatch.Stop();
            // TODO - check if the ellapsed time in milliseconds is > 0
            // If yes show the time.
            // If no show "FOUL START" 
            if (myWatch.ElapsedMilliseconds > 0)
            {
                timeLabel.Text = $"0." + myWatch.ElapsedMilliseconds.ToString();
            }
            else
            {
                timeLabel.Text = $"Foul Start";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch
            myWatch.Reset();
            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen
            row1col1.BackColor = Color.DimGray;
            row1col2.BackColor = Color.DimGray;
            row2col1.BackColor = Color.DimGray;
            row2col2.BackColor = Color.DimGray;
            row3col1.BackColor = Color.DimGray;
            row3col2.BackColor = Color.DimGray;
            row4col1.BackColor = Color.DarkOliveGreen;
            row4col2.BackColor = Color.DarkOliveGreen;
            // TODO - reset row value and timeLabel text
            currentRow = 0;
            timeLabel.Text = $"0.000"; 
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            // TODO - create a switch block that checks currentRow. In each case
            
            // it will light up the appropriate lights, (labels). 
            if (currentRow == 1)
            {
                row1col1.BackColor = Color.Green;
                row1col2.BackColor = Color.Green;
                currentRow++;
            }
            else if (currentRow == 2)
            {
                row2col1.BackColor = Color.Green;
                row2col2.BackColor = Color.Green;
                currentRow++;
            }
            else if (currentRow == 3)
            {
                row3col1.BackColor = Color.Green;
                row3col2.BackColor = Color.Green;
                currentRow++;
            }
            else if (currentRow == 4)
            {
                row4col1.BackColor = Color.Green;
                row4col2.BackColor = Color.Green;
                currentRow++;
                myWatch.Start(); 
            }
            else
            { }      
        }
    }
}
