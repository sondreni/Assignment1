using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int RandomSensorValue(int Lower, int Upper)
        {

            return rnd.Next(Lower, Upper);

        }
        public void UpdateSensors()
        {

        }
        public void ReadSensors()
        {

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {

        }

        private void btnLogging_Click(object sender, EventArgs e)
        {

        }
    }
}
