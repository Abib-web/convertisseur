using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertBinary
{
    public partial class Form1 : Form
    {
        // Table de vérité (valeur,A,B,C,D,E,F,G) pour l'affichage des segments
        private int[,] LS7447 = new int[,]
        { //0 1 2 3 4 5 6
{1,1,1,1,1,1,0}, // 0
{0,1,1,0,0,0,0}, // 1
{1,1,0,1,1,0,1}, // 2
{1,1,1,1,0,0,1}, // 3
{0,1,1,0,0,1,1}, // 4
{1,0,1,1,0,1,1}, // 5
{1,0,1,1,1,1,1}, // 6
{1,1,1,0,0,0,0}, // 7
{1,1,1,1,1,1,1}, // 8
{1,1,1,0,0,1,1}, // 9
{1,1,1,0,1,1,1}, // A
{0,0,1,1,1,1,1}, // B
{1,0,0,1,1,1,0}, // C
{0,1,1,1,1,0,1}, // D
{1,0,0,1,1,1,1}, // E
{1,0,0,0,1,1,1} // F
        };
        private Label[] septSegments = new Label[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            septSegments[0] = lblSeg_A;
            septSegments[1] = lblSeg_B;
            septSegments[2] = lblSeg_C;
            septSegments[3] = lblSeg_D;
            septSegments[4] = lblSeg_E;
            septSegments[5] = lblSeg_F;
            septSegments[6] = lblSeg_G;
            // Pour afficher le tout en fonction des "ValueChanged"
            nudDecimal.Value = 0;
        }
       

        private void radDecimal_CheckedChanged(object sender, EventArgs e)
        {
            nudDecimal.Enabled = radDecimal.Checked;
        }

        private void radBinaire_CheckedChanged(object sender, EventArgs e)
        {
            nudBinaire0.Enabled = nudBinaire1.Enabled = nudBinaire2.Enabled = nudBinaire3.Enabled = radBinaire.Checked ;
        }

        private void radHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            nudHexadecimal.Enabled = radHexadecimal.Checked;
        }

        private void nudDecimal_ValueChanged(object sender, EventArgs e)
        {
            if (radDecimal.Checked)
            {
                nudHexadecimal.Value = nudDecimal.Value;
                AffecterValeur(Convert.ToInt16(nudHexadecimal.Value));
                Affiche7Segments(Convert.ToInt16(nudDecimal.Value));
            }
        }

        private void nudHexadecimal_ValueChanged(object sender, EventArgs e)
        {
            if (radHexadecimal.Checked)
            {
                nudDecimal.Value = nudHexadecimal.Value;
                AffecterValeur(Convert.ToInt16(nudHexadecimal.Value));
                Affiche7Segments(Convert.ToInt16(nudHexadecimal.Value));
            }
        }

        private void AffecterValeur(int valeur)
        {
            nudBinaire0.Value = valeur % 2;
            valeur >>= 1;
            nudBinaire1.Value = valeur %2;
            valeur >>= 1;
            nudBinaire2.Value = valeur % 2;
            valeur >>= 1;
            nudBinaire3.Value = valeur % 2;
        }

        private void nudBinaire_ValueChanged(object sender, EventArgs e)
        {
            if (radBinaire.Checked)
            {
                
                decimal v = (nudBinaire3.Value * 8) + (nudBinaire2.Value * 4) + (nudBinaire1.Value * 2) + (nudBinaire0.Value);
                nudDecimal.Value = v;
                nudHexadecimal.Value = v;
                Affiche7Segments((int)v);
            }
        }
        /// <summary>
        /// Affiche la valeur sur le pseudo 7 segments représenté par 7 Libellés
        /// </summary>
        /// <param name="valeur">La valeur à afficher (0-15).</param>
        private void Affiche7Segments(int valeur)
        {
            for (int i = 0; i < 7; ++i)
                if (LS7447[valeur, i] == 1)
                    septSegments[i].BackColor = Color.Green;
                else
                    septSegments[i].BackColor = Color.LightGray;
        }

        private void chkActiveCompteur_CheckedChanged(object sender, EventArgs e)
        {
            clkSeconde.Enabled = chkActiveCompteur.Checked;
        }

        private void clkSeconde_Tick(object sender, EventArgs e)
        {
            if (nudDecimal.Value == 15)
                nudDecimal.Value = 0;
            else
                ++nudDecimal.Value;
            AffecterValeur((int)nudDecimal.Value);
            nudHexadecimal.Value = nudDecimal.Value;

        }
    }
}
