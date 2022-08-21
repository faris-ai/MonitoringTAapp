using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringTAapp
{
    public partial class Login : Form
    {
        Form1 form = new Form1();
        public Login()
        {
            InitializeComponent();
        }

        
    private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(userTB.Text == "Dosen1" && passTB.Text == "Admin")
            {
                form.ShowDialog();
                
            } else
            {
                DialogResult dr = MessageBox.Show("Username atau password yang anda masukkan salah", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
