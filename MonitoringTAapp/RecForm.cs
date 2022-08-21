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
    public partial class RecForm : Form
    {
        string query;
        Proses p = new Proses();
        static int noR = 0000;
        bool isEdit = false;
        public RecForm(int no, string namaMhs, string namaDsn, DateTime tanggalBim, string urai, bool isDis)
        {
            InitializeComponent();
            query = "SELECT NamaMhs FROM Orang.Mahasiswa";
            foreach (string item in p.tampilCB(query))
            {
                namaMhsCB.Items.Add(item);
            }
            namaMhsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            query = "SELECT NamaDsn FROM Orang.Dosen";
            foreach (string item in p.tampilCB(query))
            {
                namaDsnCB.Items.Add(item);
            }
            namaDsnCB.DropDownStyle = ComboBoxStyle.DropDownList;
            if (isDis)
            {
                viewBtn.Visible = true;
                editBtn.Visible = true;
                hapusBtn.Visible = true;
                saveBtn.Visible = false;
                namaMhsCB.Enabled = false;
                namaDsnCB.Enabled = false;
                tbimDateTimePicker.Enabled = false;
                uraiTB.Enabled = false;
                refUBtn.Enabled = false;
                isEdit = true;
                noR = no;
                labelJ.Text = "Data Record Bimbingan";
            }
            namaMhsCB.Text = namaMhs;
            namaDsnCB.Text = namaDsn;
            tbimDateTimePicker.Value = tanggalBim;
            uraiTB.Text = urai;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        int generateNo(int taId)
        {
            int no = 0;
            string noResult;
            string taFormat = taId.ToString();
            int start = 1;
            noResult = taFormat + start;
            while (p.isDataSamaAda("SELECT Uraian FROM TA.Bimbingan WHERE No = @no", "no", noResult))
            {
                start++;
                noResult = taFormat + start;
            }
            no = Convert.ToInt32(noResult);
            return no;
        }

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namaMhsCB_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT TanggalMulai, TanggalBatas FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NamaMhs = '"+ namaMhsCB.Text + "')";
            List<DateTime> ldt = p.ambilTggl(query);
            if (ldt[0] > tbimDateTimePicker.MaxDate)
            {
                tbimDateTimePicker.MaxDate = ldt[1];
                tbimDateTimePicker.MinDate = ldt[0];
            } else
            {
                tbimDateTimePicker.MinDate = ldt[0];
                tbimDateTimePicker.MaxDate = ldt[1];
            }
            if (!isEdit)
                noR = generateNo(Convert.ToInt32(p.tampilNama("SELECT TaId FROM Orang.Mahasiswa WHERE NamaMhs = @nm", "nm", namaMhsCB.Text)));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (namaMhsCB.Text.Equals("") || namaDsnCB.Text.Equals("") || uraiTB.Text.Equals(""))
            {
                DialogResult dr = MessageBox.Show("Data harus diisi dengan lengkap\n\nTidak ada yang boleh kosong", "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string format = "yyyy-MM-dd";
                p.insertDataBim(noR, namaMhsCB.Text, namaDsnCB.Text, tbimDateTimePicker.Value.ToString(format) + " " + tbimDateTimePicker.Value.TimeOfDay.Hours.ToString() + ":" +
                    tbimDateTimePicker.Value.TimeOfDay.Minutes.ToString() + ":" + tbimDateTimePicker.Value.TimeOfDay.Seconds.ToString(), uraiTB.Text, isEdit);
                this.Close();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            viewBtn.Visible = false;
            editBtn.Visible = false;
            hapusBtn.Visible = false;
            saveBtn.Visible = true;
            //namaMhsCB.Enabled = true;
            //namaDsnCB.Enabled = true;
            tbimDateTimePicker.Enabled = true;
            uraiTB.Enabled = true;
            refUBtn.Enabled = true;
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Apakah anda yakin ingin menghapus data ini??", "PERINGATAN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                p.hapusDataBim(noR);
                this.Close();
            }
        }

        private void refUBtn_Click(object sender, EventArgs e)
        {
            uraiTB.Text = "";
            uraiTB.Select();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            MahaForm mf = new MahaForm(p.tampilNama("SELECT NIM FROM Orang.Mahasiswa WHERE NamaMhs = @nm", "nm", namaMhsCB.Text), namaMhsCB.Text, p.tampilNama("SELECT Asal FROM Orang.Mahasiswa WHERE NamaMhs = @nm", "nm", namaMhsCB.Text), p.tampilNama("SELECT Notel FROM Orang.Mahasiswa WHERE NamaMhs = @nm", "nm", namaMhsCB.Text),
                p.tampilNama("SELECT Judul FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NamaMhs = @nm)", "nm", namaMhsCB.Text), true);
            mf.ShowDialog();
            this.Close();
        }
    }
}
