using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class loading : Form
    {
        int timer = 20; //20 secondes
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = timer.ToString();
            timer -= 1;

            if (timer < 0)
            {
                Form1 MAIN = new Form1();
                MAIN.Show();
                this.Hide();
                timer1.Stop();
            }
            else
            {

            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
