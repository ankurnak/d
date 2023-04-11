using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp60
{
    public partial class Form1 : Form
    {
        private Fraction fraction1;
        private Fraction fraction2;
        public Form1()
        {
            InitializeComponent();
            
        }
        class Fraction
        {
            private int numerator;
            private int denominator;
            public int Numerator { get; set; }
            public int Denominator { get; set; }
            public Fraction(int num, int den)
            {
                numerator = num;
                denominator = den;
            }
            public static Fraction operator +(Fraction a, Fraction b)
            {
                int num = a.numerator * b.denominator + b.numerator * a.denominator;
                int den = a.denominator * b.denominator;
                return new Fraction(num, den);
            }
            public static Fraction operator -(Fraction a, Fraction b)
            {
                int num = a.numerator * b.denominator - b.numerator * a.denominator;
                int den = a.denominator * b.denominator;
                return new Fraction(num, den);
            }
            public static Fraction operator *(Fraction a, Fraction b)
            {
                int num = a.numerator * b.numerator;
                int den = a.denominator * b.denominator;
                return new Fraction(num, den);
            }
            public static Fraction operator /(Fraction a, Fraction b)
            {
                int num = a.numerator * b.denominator;
                int den = a.denominator * b.numerator;
                return new Fraction(num, den);
            }
            public static Fraction operator ^(Fraction a, int n)
            {
                int num = (int)Math.Pow(a.numerator, n);
                int den = (int)Math.Pow(a.denominator, n);
                return new Fraction(num, den);
            }
            public static bool operator ==(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator == b.numerator * a.denominator;
            }
            public static bool operator !=(Fraction a, Fraction b)
            {
                return !(a == b);
            }
            public static bool operator >(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator > b.numerator * a.denominator;
            }
            public static bool operator >=(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator >= b.numerator * a.denominator;
            }
            public static bool operator <(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator < b.numerator * a.denominator;
            }
            public static bool operator <=(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator <= b.numerator * a.denominator;
            }
            public override string ToString()
            {
                return numerator.ToString() + "/" + denominator.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxNumerator1.Text);
            int den = int.Parse(textBoxDenominator1.Text);
            fraction1 = new Fraction(num, den);
            labelFraction1.Text = fraction1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxNumerator2.Text);
            int den = int.Parse(textBoxDenominator2.Text);
            fraction2 = new Fraction(num, den);
            labelFraction2.Text = fraction2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction result = fraction1 + fraction2;
            labelResult.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction result = fraction1 - fraction2;
            labelResult.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction result = fraction1 * fraction2;
            labelResult.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fraction result = fraction1 / fraction2;
            labelResult.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fraction result = new Fraction(fraction1.Numerator / gcd(fraction1.Numerator, fraction1.Denominator),
                                       fraction1.Denominator / gcd(fraction1.Numerator, fraction1.Denominator));
            labelResult.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxPower.Text);
            Fraction result = fraction1 ^ n;
            labelResult.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool result = fraction1 == fraction2;
            labelResult.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool result = fraction1 != fraction2;
            labelResult.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool result = fraction1 > fraction2;
            labelResult.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool result = fraction1 >= fraction2;
            labelResult.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool result = fraction1 < fraction2;
            labelResult.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool result = fraction1 <= fraction2;
            labelResult.Text = result.ToString();
        }
        private int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
