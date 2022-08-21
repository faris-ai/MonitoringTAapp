using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringTAapp
{
    public partial class TAForm : Form
    {
        static int taId = 000;
        Proses p = new Proses();
        bool isEdit = false;
        public TAForm(int id, string jdl, int thn, string smtr, DateTime tm, DateTime tb, bool isDis)
        {
            InitializeComponent();
            judulTB.Select();
            taYearPicker.CustomFormat = "yyyy";
            semesterCB.Items.Add("Ganjil");
            semesterCB.Items.Add("Genap");
            semesterCB.DropDownStyle = ComboBoxStyle.DropDownList;
            if (isDis)
            {
                viewBtn.Visible = true;
                editBtn.Visible = true;
                hapusBtn.Visible = true;
                saveBtn.Visible = false;
                judulTB.Enabled = false;
                taYearPicker.Enabled = false;
                semesterCB.Enabled = false;
                tmDateTimePicker.Enabled = false;
                tbDateTimePicker.Enabled = false;
                button1.Enabled = false;
                taId = id;
                labelJ.Text = "Data Tugas Akhir";
            } else
            {
                taId = generateTaId();
            }
            judulTB.Text = jdl;
            taYearPicker.Text = "01/01/" + thn.ToString();
            semesterCB.Text = smtr;
            tmDateTimePicker.Value = tm;
            tbDateTimePicker.Value = tb;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        int generateTaId()
        {
            int taid = 0;
            string taResult;
            string taFormat = "00";
            int start = 1;
            taResult = start + taFormat;
            while (p.isDataSamaAda("SELECT Judul FROM TA.TugasAkhir WHERE TaId = @ti", "ti", taResult))
            {
                start++;
                taResult = start + taFormat;
            }
            taid = Convert.ToInt32(taResult);
            return taid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            judulTB.Text = "";
            judulTB.Select();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            tbDateTimePicker.MinDate = tmDateTimePicker.Value;
            if (!isEdit)
                tbDateTimePicker.Value = tmDateTimePicker.Value;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (judulTB.Text.Equals("") || semesterCB.Text.Equals(""))
            {
                DialogResult dr = MessageBox.Show("Data harus diisi dengan lengkap\n\nTidak ada yang boleh kosong", "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string format = "yyyy-MM-dd";
                p.insertDataTA(taId, judulTB.Text, taYearPicker.Value.Year.ToString(), semesterCB.Text, tmDateTimePicker.Value.ToString(format), tbDateTimePicker.Value.ToString(format), isEdit);
                this.Close();
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            hapusBtn.Visible = false;
            saveBtn.Visible = true;
            judulTB.Enabled = true;
            taYearPicker.Enabled = true;
            semesterCB.Enabled = true;
            tmDateTimePicker.Enabled = true;
            tbDateTimePicker.Enabled = true;
            button1.Enabled = true;
            isEdit = true;
            judulTB.Select();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Apakah anda yakin ingin menghapus data ini??", "PERINGATAN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.Yes)
            {
                p.hapusDataTA(taId);
                this.Close();
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewForm vf = new ViewForm(p.tampilNama("SELECT Judul FROM TA.TugasAkhir WHERE TaId = @id", "id", taId.ToString()));
            vf.ShowDialog();
        }
    }
}
