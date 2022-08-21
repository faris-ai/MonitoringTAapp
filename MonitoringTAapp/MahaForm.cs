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
    public partial class MahaForm : Form
    {
        static string nimp;
        string query;
        Proses p = new Proses();
        bool isEdit = false;
        public MahaForm(string nim, string nama, string asal, string notel, string judul, bool isDis)
        {
            InitializeComponent();
            nimTB.Select();
            query = "SELECT Judul FROM TA.TugasAkhir";
            foreach(string item in p.tampilCB(query))
            {
                judulCB.Items.Add(item);
            }
            judulCB.DropDownStyle = ComboBoxStyle.DropDownList;
            if (isDis)
            {
                viewBtn.Visible = true;
                editBtn.Visible = true;
                hapusBtn.Visible = true;
                saveBtn.Visible = false;
                nimTB.Enabled = false;
                namaMhsTB.Enabled = false;
                asalTB.Enabled = false;
                notelTB.Enabled = false;
                judulCB.Enabled = false;
                refBtn.Enabled = false;
                refBtn2.Enabled = false;
                refBtn3.Enabled = false;
                refBtn4.Enabled = false;
                nimp = nim;
                labelJ.Text = "Data Mahasiswa";
            }
            nimTB.Text = nim;
            namaMhsTB.Text = nama;
            asalTB.Text = asal;
            notelTB.Text = notel;
            judulCB.Text = judul;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Ini adalah contoh Polymorphism
        /// Polymorphism adalah Kemampuan objek-objek  untuk merespon secara berbeda terhadap suatu pesan yang sama
        /// </summary>
        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void nimTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
            if (nimTB.Text.Length >= 11)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("NIM tidak boleh lebih dari 11 karakter");
                    e.KeyChar = (char)0;
                }
            }
            if (e.KeyChar == 13)
            {
                namaMhsTB.Select();
            }
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            nimTB.Text = "";
            nimTB.Select();
        }

        private void refBtn2_Click(object sender, EventArgs e)
        {
            namaMhsTB.Text = "";
            namaMhsTB.Select();
        }

        private void refBtn3_Click(object sender, EventArgs e)
        {
            asalTB.Text = "";
            asalTB.Select();
        }

        private void refBtn4_Click(object sender, EventArgs e)
        {
            notelTB.Text = "";
            notelTB.Select();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nimTB.Text.Equals("") || namaMhsTB.Text.Equals("") || asalTB.Text.Equals("") || notelTB.Text.Equals("") || judulCB.Text.Equals(""))
            {
                DialogResult dr = MessageBox.Show("Data harus diisi dengan lengkap\n\nTidak ada yang boleh kosong", "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } else
            {
                if (nimTB.Text.Length < 11)
                {
                    DialogResult dr = MessageBox.Show("NIM tidak boleh kurang dari 11 karakter", "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (p.isDataSamaAda("SELECT NIM FROM Orang.Mahasiswa WHERE TaId = (SELECT TaId From TA.TugasAkhir WHERE Judul = @text)", "text", judulCB.Text) && !isEdit)
                    {
                        DialogResult dr = MessageBox.Show("Data tugas akhir ini sudah digunakan\n\nCobalah untuk memilih atau menambah data tugas akhir lain", "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        if (!isEdit)
                        {
                            DialogResult r = MessageBox.Show("Apakah anda yakin NIM sudah benar??\n\nNB: NIM tidak dapat diedit", "PERINGATAN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (r == DialogResult.Yes)
                            {
                                p.insertDataMhs(nimTB.Text, namaMhsTB.Text, asalTB.Text, notelTB.Text, judulCB.Text, isEdit);
                                this.Close();
                            }
                        }
                        else
                        {
                            p.insertDataMhs(nimTB.Text, namaMhsTB.Text, asalTB.Text, notelTB.Text, judulCB.Text, isEdit);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            viewBtn.Visible = false;
            editBtn.Visible = false;
            hapusBtn.Visible = false;
            saveBtn.Visible = true;
            namaMhsTB.Enabled = true;
            asalTB.Enabled = true;
            notelTB.Enabled = true;
            judulCB.Enabled = true;
            refBtn2.Enabled = true;
            refBtn3.Enabled = true;
            refBtn4.Enabled = true;
            isEdit = true;
            namaMhsTB.Select();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Apakah anda yakin ingin menghapus data ini??", "PERINGATAN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                p.hapusDataMhs(nimp);
                this.Close();
            }
        }

        private void namaMhsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                asalTB.Select();
            }
        }

        private void asalTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                notelTB.Select();
            }
        }

        private void notelTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                judulCB.Select();
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            TAForm tf = new TAForm(Convert.ToInt32(p.tampilNama("SELECT TaId FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NIM = @nim)", "nim", nimTB.Text)),
                judulCB.Text, Convert.ToDateTime(p.tampilNama("SELECT Tahun FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NIM = @nim)", "nim", nimTB.Text)).Year,
                p.tampilNama("SELECT Semester FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NIM = @nim)", "nim", nimTB.Text),
                Convert.ToDateTime(p.tampilNama("SELECT TanggalMulai FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NIM = @nim)", "nim", nimTB.Text)),
                Convert.ToDateTime(p.tampilNama("SELECT TanggalBatas FROM TA.TugasAkhir WHERE TaId = (SELECT TaId FROM Orang.Mahasiswa WHERE NIM = @nim)", "nim", nimTB.Text)), true);
            tf.ShowDialog();
            this.Close();
        }
    }
}
