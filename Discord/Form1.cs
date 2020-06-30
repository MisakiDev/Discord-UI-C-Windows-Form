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
    public partial class Form1 : Form
    {
        public static Point newpoint = new Point();
        public static int x;
        public static int y;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {

        }

        #region "System Move Title Panel"

        private void xMouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - base.Location.X;
            y = Control.MousePosition.Y - base.Location.Y;
        }
        private void xMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                newpoint = Control.MousePosition;
                newpoint.X -= x;
                newpoint.Y -= y;
                base.Location = newpoint;
            }
        }

        #endregion 

        private void button1_Click(object sender, EventArgs e) 
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.MouseDown += this.xMouseDown; //For Move Form
            this.panel1.MouseMove += this.xMouseMove; //For Move Form
            this.panel1.MouseDown += this.xMouseDown; //For Move Form
            this.panel1.MouseMove += this.xMouseMove; //For Move Form
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel6.Controls.Add(childForm);
            panel6.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //Channel
            openChildFormInPanel(new channels());
            hideSubMenu();
        }
    }
}
