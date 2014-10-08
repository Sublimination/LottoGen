using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumbers
{
    public partial class Lottery : Form
    {
        public Lottery()
        {
            InitializeComponent();
        }
        // Setup array as integers 
        int[] myNumbers;
      

        private void button1_Click(object sender, EventArgs e)
        {
            // set rnd as random variable
            Random rnd = new Random();
            // Set array length
            myNumbers = new int[6];
            //init tempNumber
            int tmpNumber = 0;
            // For loop to iterate through array 
            for (int i = 0; i < 6; i++)
            {
                // Generate random number
                tmpNumber = rnd.Next(1, 50);
                
                //Check tmpNumber is not in myNumbers
                if (!myNumbers.Contains(tmpNumber))
                {
                    //Add number to array
                    myNumbers[i] = tmpNumber;
                }
                else
                {
                    //redo
                    i--;
                }
            }
            // Sort array, lowest number first
            Array.Sort(myNumbers);

            // Give each textbox the value stored in array[index]
            txtDisplay1.Text = myNumbers[0].ToString();
            txtDisplay2.Text = myNumbers[1].ToString();
            txtDisplay3.Text = myNumbers[2].ToString();
            txtDisplay4.Text = myNumbers[3].ToString();
            txtDisplay5.Text = myNumbers[4].ToString();
            txtDisplay6.Text = myNumbers[5].ToString();
            txtGoodLuck.Visible = true;
        }
    }
}
