using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool runSampling = false;
        bool runLogging = false;
        double TimeToSample = 0;
        double TimeToLogg = 0;
        AnalogSensor[] ASensor;
        DigitalSensor[] DSensor;
        int Resolution;
        bool Header=true;
      
        


        public Form1()           
        {
            InitializeComponent();
            SetNewValues();
        }
        

        private void SetNewValues()
        {
            
            Resolution = Convert.ToInt32(Math.Pow(2, 20));
            ASensor = new AnalogSensor[3];
            DSensor = new DigitalSensor[1];

            

            for (int i = 0; i < ASensor.Length; i++)
            {
                ASensor[i] = new AnalogSensor(("Analog Sensor " + Convert.ToString(i+1)),"V");

            }
            for (int i = 0; i < DSensor.Length; i++)
            {
                DSensor[i] = new DigitalSensor(("Digital Sensor " + Convert.ToString(i+1)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void UpdateSensors()
        {

            for (int i = 0;i < ASensor.Length; i ++)
            {
                ASensor[i].Value = ((Convert.ToDouble(rnd.Next(0, Resolution)) / Resolution) * 2 - 1);
                
            }
            for (int i = 0; i < DSensor.Length; i++)
            {
                DSensor[i].Value = rnd.Next(0, 2);
            }
        }
        public void ReadSensors()
        {
            string tekst = "";
            for (int i = 0; i < ASensor.Length; i++)
            {
                tekst = tekst + ASensor[i].TagID +": "+ Convert.ToString(ASensor[i].Value)+" "+ ASensor[i].EngUnit + "\n";
                
            }
            for (int i = 0; i < DSensor.Length; i++)
            {
                tekst = tekst + DSensor[i].TagID + ": " + Convert.ToString(DSensor[i].Value) + "\n";
            }
            txtSensorData.Text = tekst;
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            
            
            if (runSampling)
            {
                timer1.Stop();
                runSampling = false;
                btnLogging.Enabled = false;
                runLogging = false;
            }

            else
            {
                timer1.Start();
                runSampling = true;
                btnLogging.Enabled = true;
            }
                


        }

        private void btnLogging_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txtNextSamplingTime.Text = Convert.ToString(TimeToSample);
            
            if (runSampling)
            {
                if (TimeToSample == 0)
                {
                    TimeToSample = 2.0;
                    UpdateSensors();
                    ReadSensors();

                }
                else
                {
                    TimeToSample -= 0.1;
                    TimeToSample = Math.Round(TimeToSample, 1);
                }
                if (runLogging)
                {
                    txtNextLoggingTime.Text = Convert.ToString(TimeToLogg);
                    if (TimeToLogg == 0)
                    {
                        string tekst = "";
                        if (Header)
                        {
                            tekst = "Tidspunkt;";
                            for (int i = 0; i < ASensor.Length; i++)
                                tekst = tekst + ASensor[i].TagID + ";";
                            for (int i = 0; i < DSensor.Length; i++)
                                tekst = tekst + DSensor[i].TagID + ";";
                            tekst = tekst + "\n";
                            Header = false;
                        }
                        DateTime DateAndTime = DateTime.Now;
                        tekst = tekst + DateAndTime.ToString("yyyy.MM.dd HH:mm:ss")+";";
                        for (int i = 0; i < ASensor.Length; i++)
                            tekst = tekst +Convert.ToString(ASensor[i].Value) + ";";
                        for (int i = 0; i < DSensor.Length; i++)
                            tekst = tekst + Convert.ToString(DSensor[i].Value) + ";";

                        tekst = tekst + "\n";


                        File.AppendAllText("test.csv", tekst);
                        TimeToLogg = 13;

                    }
                    else
                    {
                        TimeToLogg -= 0.1;
                        TimeToLogg = Math.Round(TimeToLogg, 1);
                    }
                }
            }
        }

        private void btnLogging_Click_1(object sender, EventArgs e)
        {
            if (runLogging)
            {
                runLogging = false;
            }

            else
            {
                runLogging = true;
            }
        }
    }
}
