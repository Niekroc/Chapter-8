using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // Aanmaken van de Array
            int[] Dices = new int[6];

            //Vullen van de Array met random getallen
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = GenerateRandomNumber();
            }
            // Waardes uit de array weergeven om de textboxes op het scherm
            txtDice1.Text = Convert.ToString(Dices[0]);
            txtDice2.Text = Convert.ToString(Dices[1]);
            txtDice3.Text = Convert.ToString(Dices[2]);
            txtDice4.Text = Convert.ToString(Dices[3]);
            txtDice5.Text = Convert.ToString(Dices[4]);
            txtDice6.Text = Convert.ToString(Dices[5]);

            txtSum.Text = CalculateSum(Dices).ToString();
            txtAverage.Text = CalculateAverage(Dices).ToString();
            txtRange.Text = CalculateRange(Dices).ToString();
            txtDeviation.Text = CalculateStandardDeviation(Dices).ToString();
        }

        private int CalculateStandardDeviation(int[] dices)
        {
            double average = Convert.ToDouble(CalculateAverage(dices));
            double[] averageDeviation = new double[dices.Length];
            for (int i = 0; i < dices.Length; i++)
            {
                Math.Pow(dices[i] - average, 2);
            }
            double sumaverageDeviation = CalculateSum(averageDeviation);
            double variation = sumaverageDeviation / (averageDeviation.Length - 1);
            return Math.Sqrt(variation);
        }

        private int CalculateRange(int[] Dices)
        {
            int hoogsteGetal = 0;
            // Zet laagste getal standaard op 6 andere wordt het laagste getal nooit bepaald wanneer deze op 0 staat
            int laagsteGetal = 0;
            // Berekend de range hoogste getal uit de array - laagste getal uit de array
            for (int i = 0; i < Dices.Length; i++)
            {
                if(Dices[i] > hoogsteGetal)
                {
                    // maak het getal uit de array het hoogste getal
                    hoogsteGetal = Dices[i];
                }
                if(Dices[i] < laagsteGetal)
                {
                    //maak het getal uit de array het laagste getal
                    laagsteGetal = Dices[i];
                }
            }
            // return de range
            return hoogsteGetal - laagsteGetal;
        }

        private decimal CalculateAverage(int[] dices)
        {
            // Roep de methode calculateSum aan oom de som te berekenen
            decimal sum = CalculateSum(dices);

            return Math.Round(sum / dices.Length);
        }
            
        private int CalculateSum(int[] dices)
        {
            int sum = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                sum += dices[i];
            }
            return sum;
        }

        private int GenerateRandomNumber()
        {
            return rnd.Next(1, 7);
        }
    }

}
