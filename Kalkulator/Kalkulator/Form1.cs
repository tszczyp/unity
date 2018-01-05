using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double Liczba;
        string Operacja;
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if(Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "1";
            }
            else
            {
                Wynik.Text = Wynik.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "2";
            }
            else
            {
                Wynik.Text = Wynik.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "3";
            }
            else
            {
                Wynik.Text = Wynik.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "4";
            }
            else
            {
                Wynik.Text = Wynik.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "5";
            }
            else
            {
                Wynik.Text = Wynik.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "6";
            }
            else
            {
                Wynik.Text = Wynik.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "7";
            }
            else
            {
                Wynik.Text = Wynik.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "8";
            }
            else
            {
                Wynik.Text = Wynik.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (Wynik.Text == "0" && Wynik.Text != null)
            {
                Wynik.Text = "9";
            }
            else
            {
                Wynik.Text = Wynik.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            Wynik.Text = Wynik.Text + "0";
        }

        private void doda_Click(object sender, EventArgs e)
        {
            Liczba = Convert.ToDouble(Wynik.Text);
            Wynik.Text = "0";
            Operacja = "+";
        }

        private void odej_Click(object sender, EventArgs e)
        {
            Liczba = Convert.ToDouble(Wynik.Text);
            Wynik.Text = "0";
            Operacja = "-";
        }

        private void mnoz_Click(object sender, EventArgs e)
        {
            Liczba = Convert.ToDouble(Wynik.Text);
            Wynik.Text = "0";
            Operacja = "*";
        }

        private void dziel_Click(object sender, EventArgs e)
        {
            Liczba = Convert.ToDouble(Wynik.Text);
            Wynik.Text = "0";
            Operacja = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Wynik.Text = "0";
        }

        private void rowne_Click(object sender, EventArgs e)
        {
            double Liczba2;
            double wynik;

            Liczba2 = Convert.ToDouble(Wynik.Text);
            if (Operacja == "+")
            {
                wynik = (Liczba + Liczba2);
                Wynik.Text = Convert.ToString(wynik);
                Liczba = wynik;
            }
            if (Operacja == "-")
            {
                wynik = (Liczba - Liczba2);
                Wynik.Text = Convert.ToString(wynik);
                Liczba = wynik;
            }
            if (Operacja == "*")
            {
                wynik = (Liczba * Liczba2);
                Wynik.Text = Convert.ToString(wynik);
                Liczba = wynik;
            }
            if (Operacja == "/")
            {
                if(Liczba2 == 0)
                {
                    Wynik.Text = "Error";
                }
                else
                {
                    wynik = (Liczba / Liczba2);
                    Wynik.Text = Convert.ToString(wynik);
                    Liczba = wynik;
                }
            }
        }
    }
}
