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

namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stopwatch km = new Stopwatch(); 

        private void buton2Basla_Click(object sender, EventArgs e)
        {
            if (!km.IsRunning) 
            {
                km.Start();
            } 
        }

        private void butonBekle_Click(object sender, EventArgs e)
        {
           if(km.IsRunning) 
            { 
                km.Stop();  
            }
            
            
           
        }

        private void butonTekrar_Click(object sender, EventArgs e)
        {
            kronometre.Text = "00:00:00:00:000";
            km.Reset();
        }

        private void timer1Kronometre_Tick(object sender, EventArgs e)
        {
            if(km.IsRunning)
            {
                TimeSpan ts = km.Elapsed; //timespan zaman aralığı demek 
                kronometre.Text=string.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                    ts.Hours,ts.Minutes,ts.Seconds,ts.Milliseconds); 
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxKayıtlar.Items.Add(kronometre.Text);  

        }
    }
}
