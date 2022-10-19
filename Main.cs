using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Main : Form
    {
        int x, y, xVal, yVal;
        Timer tm;
        private EventHandler display;

        public Main()
        {
            InitializeComponent();
            x = 10;
            y = 10;
            xVal = 5;
            yVal = 5;
            tm = new Timer();
            tm.Interval = 80;
            tm.Tick += new EventHandler(Display);
            tm.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Celcius to Fahrenheit")
            {
                double Result = Convert.ToDouble(textBox1.Text);
                label2.Text = CelciusToFahrenheit(Result);
            }
            else if (comboBox1.Text == "Fahrenheit to Celcius")
            {
                double Result = Convert.ToDouble(textBox1.Text);
                label2.Text = FahrenheitToCelcius(Result);
            }
            if (comboBox1.Text == "Kelvin to Celcius")
            {
                double Result = Convert.ToDouble(textBox1.Text);
                label2.Text = KelvinToCelcius(Result);
            }
            else if (comboBox1.Text == "Celcius to Kelvin")
            {
                double Result = Convert.ToDouble(textBox1.Text);
                label2.Text = CelciusToKelvin(Result);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Display(sender, e);
        }


        private string CelciusToFahrenheit(double Temperature)
        {
            double Result = (Temperature * 9 / 5) + 32;
            return Result.ToString();
        }
        private string FahrenheitToCelcius(double Temperature)
        {
            double Result = (Temperature - 32) * 5 / 9;
            return Result.ToString();

        }
        private string KelvinToCelcius(double Temperature)
        {
            double Result = (Temperature - 273.15);
            return Result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string CelciusToKelvin(double Temperature)
        {
            double Result = (Temperature + 273.15);
            return Result.ToString();
        }
        private void Display(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(Brushes.Black, new Rectangle(x, y, 50, 50));
            x += xVal;
            y += yVal;
            pictureBox1.Image = bmp;
            if (x <= 0 || x >= (pictureBox1.Width - 50))
            {
                xVal = xVal * (-1);
            }
            if (y <= 0 || y >= (pictureBox1.Height - 50))
            {
                yVal *= -1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 400);
           
        }
    }
}
