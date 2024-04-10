using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            mainpan.Controls.Clear();
            frmRep Rep = new frmRep();
            Rep.TopLevel = false;
            Rep.FormBorderStyle = FormBorderStyle.None;
            Rep.Dock = DockStyle.Fill;
            mainpan.Controls.Add(Rep);
            Rep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRep().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            mainpan.Controls.Clear();
            frmRep Rep = new frmRep();
            Rep.TopLevel = false;
            Rep.FormBorderStyle = FormBorderStyle.None;
            Rep.Dock = DockStyle.Fill;
            mainpan.Controls.Add(Rep);
            Rep.Show();
        }

        private void mainpan_Paint(object sender, PaintEventArgs e)
        {
            mainpan.Controls.Clear();
            frmRep Rep = new frmRep();
            Rep.TopLevel = false;
            Rep.FormBorderStyle = FormBorderStyle.None;
            Rep.Dock = DockStyle.Fill;
            mainpan.Controls.Add(Rep);
            Rep.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bTNADD_Click(object sender, EventArgs e)
        {
            new Modify_Students().Show();
            this.Hide();
        }
    }
}
