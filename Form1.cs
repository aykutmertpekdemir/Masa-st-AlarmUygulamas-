using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasaustuAlarmUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.Hour.ToString();
            label5.Text = DateTime.Now.Minute.ToString();
            label6.Text = DateTime.Now.Second.ToString();

            if (comboBox1.Text == label4.Text && comboBox2.Text == label5.Text && comboBox3.Text == label6.Text)
            {
                axWindowsMediaPlayer1.URL = @"Bu alana istediginiz sarkiyi koyabilirsiniz.";
                timer1.Stop();
                MessageBox.Show("UYANMA ZAMANI");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            for (int saniye = 0; saniye < 60; saniye++)
            {
                comboBox3.Items.Add(saniye);
            }
            for (int dakika = 0; dakika < 60; dakika++)
            {
                comboBox2.Items.Add(dakika);
            }
            for (int saat = 0; saat < 24; saat++)
            {
                comboBox1.Items.Add(saat);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
