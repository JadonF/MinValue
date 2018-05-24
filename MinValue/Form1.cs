/*
 * Created by: Jadon F
 * Created on: 24-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Min Value
 * This program finds the lowest value in a randomized array
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int getMinValue(int[] tmpArray)
        {
            int tmpMin = 500;

            foreach (int inArray in tmpArray)
            {
                if (inArray < tmpMin)
                {
                    tmpMin = inArray;
                }
            }

            return tmpMin;


        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //clear list
            lstValues.Items.Clear();

            //locals
            const int MAX_ARRAY = 10;
            const int MAX_NUMBER = 500;
            int[] arrayOfValues = new int[MAX_ARRAY];
            int counter, random, minValue;
            Random rGenerator = new Random();

            //for loop
            for (counter = 0; counter < MAX_ARRAY; counter++)
            {
                random = rGenerator.Next(1, MAX_NUMBER + 1);

                lstValues.Items.Add(random);

                arrayOfValues[counter] = random;
            }

            minValue = getMinValue(arrayOfValues);

            //show message
            MessageBox.Show("The min value is " + minValue, "Min Value");
        }
    }
}

