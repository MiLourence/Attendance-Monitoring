using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring
{
    public partial class Modify_Students : Form
    {
        public Modify_Students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-C5QTHHCB\\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Student values(@ID,@Name,@Grade)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@Grade", textBoxGrade.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Success Saved");
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
