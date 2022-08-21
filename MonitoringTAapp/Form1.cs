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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace MonitoringTAapp
{
    /// <summary>
    /// Ini adalah contoh Inheritance class child Form1 dari class parent Form
    /// Inheritance adalah Mendefinisikan suatu kelas baru dengan mewarisi sifat dari kelas lain yang sudah ada
    /// </summary>
    public partial class Form1 : Form
    {
        Proses p = new Proses();
        string query;
        public Form1()
        {
            InitializeComponent();
            rPanel.Visible = true;
            mPanel.Visible = false;
            taPanel.Visible = false;
            dPanel.Visible = false;
            query = "SELECT 'Nomor' = a.No, 'Nama Mahasiswa' = b.NamaMhs, 'Tanggal Bimbingan' = a.TanggalBimbingan, a.Uraian FROM TA.Bimbingan a JOIN Orang.Mahasiswa b ON a.NIM = b.NIM";
            recordDataGridView.DataSource = p.selectQuery(query);
            recordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            refR();
        }

        private void refR()
        {
            activePan.Top = recordBtn.Top;
            rPanel.Visible = true;
            mPanel.Visible = false;
            taPanel.Visible = false;
            dPanel.Visible = false;
            query = "SELECT 'Nomor' = a.No, 'Nama Mahasiswa' = b.NamaMhs, 'Tanggal Bimbingan' = a.TanggalBimbingan, a.Uraian FROM TA.Bimbingan a JOIN Orang.Mahasiswa b ON a.NIM = b.NIM";
            recordDataGridView.DataSource = p.selectQuery(query);
            recordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void mahasiswaBtn_Click(object sender, EventArgs e)
        {
            refM();
        }

        private void refM()
        {
            activePan.Top = mahasiswaBtn.Top;
            rPanel.Visible = false;
            mPanel.Visible = true;
            taPanel.Visible = false;
            dPanel.Visible = false;
            query = "SELECT m.NIM, 'Nama Mahasiswa' = m.NamaMhs, Asal, 'No Telepon' = m.Notel, 'Tugas Akhir' = ta.Judul FROM Orang.Mahasiswa m JOIN TA.TugasAkhir ta ON m.TaID = ta.TaID";
            mahasiswaDataGridView.DataSource = p.selectQuery(query);
            mahasiswaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void taBtn_Click(object sender, EventArgs e)
        {
            refTA();
        }

        private void refTA()
        {
            activePan.Top = taBtn.Top;
            rPanel.Visible = false;
            mPanel.Visible = false;
            taPanel.Visible = true;
            dPanel.Visible = false;
            query = "SELECT 'TA ID' = TaId, 'Judul Tugas Akhir' = Judul, 'Tahun' = FORMAT(Tahun, 'yyyy'), Semester, 'Tanggal Mulai' = TanggalMulai, 'Tanggal Batas' = TanggalBatas FROM TA.TugasAkhir";
            taDataGridView.DataSource = p.selectQuery(query);
            taDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            taDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dosenBtn_Click(object sender, EventArgs e)
        {
            activePan.Top = dosenBtn.Top;
            rPanel.Visible = false;
            mPanel.Visible = false;
            taPanel.Visible = false;
            dPanel.Visible = true;
            query = "SELECT NIK, 'Nama Dosen' = NamaDsn, 'Nomor Telepon' = Notel FROM Orang.Dosen";
            dosenDataGridView.DataSource = p.selectQuery(query);
            dosenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            searchTaTB.Text = "";
            TAForm tf = new TAForm(0, "", DateTime.Now.Year, "", DateTime.Now, DateTime.Now, false);
            tf.ShowDialog();
            refTA();
        }

        private void tambahMhsBtn_Click(object sender, EventArgs e)
        {
            searchMhsTB.Text = "";
            query = "SELECT TaId FROM TA.TugasAkhir";
            if (p.selectQuery(query).Rows.Count <= 0)
            {
                MessageBox.Show("Tambah Data Tugas Akhir", "Peringatan", MessageBoxButtons.OK);
            } else
            {
                MahaForm mf = new MahaForm("", "", "", "", "", false);
                mf.ShowDialog();
                refM();
            }
        }

        private void tambahRecBtn_Click(object sender, EventArgs e)
        {
            searchRecBT.Text = "";
            query = "SELECT NIM FROM Orang.Mahasiswa";
            if (p.selectQuery(query).Rows.Count <= 0)
            {
                MessageBox.Show("Tambah Data Mahasiswa", "Peringatan", MessageBoxButtons.OK);
            } else
            {
                RecForm rf = new RecForm(0, "", "", DateTime.Now, "", false);
                rf.ShowDialog();
                refR();
            }
            
        }

        private void taDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            searchTaTB.Text = "";
            int id = Convert.ToInt32(taDataGridView.Rows[e.RowIndex].Cells[0].Value);
            string jdl = Convert.ToString(taDataGridView.Rows[e.RowIndex].Cells[1].Value);
            int thn = Convert.ToInt32(taDataGridView.Rows[e.RowIndex].Cells[2].Value);
            string smtr = Convert.ToString(taDataGridView.Rows[e.RowIndex].Cells[3].Value);
            DateTime tm = Convert.ToDateTime(taDataGridView.Rows[e.RowIndex].Cells[4].Value);
            DateTime tb = Convert.ToDateTime(taDataGridView.Rows[e.RowIndex].Cells[5].Value);

            TAForm tf = new TAForm(id, jdl, thn, smtr, tm, tb, true);
            tf.Text = "Data Tugas Akhir";
            tf.ShowDialog();
            refTA();
        }

        private void mahasiswaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            searchMhsTB.Text = "";
            string nim = Convert.ToString(mahasiswaDataGridView.Rows[e.RowIndex].Cells[0].Value);
            string nama = Convert.ToString(mahasiswaDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string asal = Convert.ToString(mahasiswaDataGridView.Rows[e.RowIndex].Cells[2].Value);
            string notel = Convert.ToString(mahasiswaDataGridView.Rows[e.RowIndex].Cells[3].Value);
            string judul = Convert.ToString(mahasiswaDataGridView.Rows[e.RowIndex].Cells[4].Value);

            MahaForm mf = new MahaForm(nim, nama, asal, notel, judul, true);
            mf.Text = "Data Mahasiswa";
            mf.ShowDialog();
            refM();
        }

        private void recordDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            searchRecBT.Text = "";
            int no = Convert.ToInt32(recordDataGridView.Rows[e.RowIndex].Cells[0].Value);
            string namaMhs = Convert.ToString(recordDataGridView.Rows[e.RowIndex].Cells[1].Value);
            DateTime tanggalBim = Convert.ToDateTime(recordDataGridView.Rows[e.RowIndex].Cells[2].Value);
            string uraian = Convert.ToString(recordDataGridView.Rows[e.RowIndex].Cells[3].Value);

            RecForm rf = new RecForm(no, namaMhs, p.tampilNama("SELECT NamaDsn FROM Orang.Dosen WHERE NIK = (SELECT NIK FROM TA.Bimbingan WHERE No = @id)", "id", no.ToString()), tanggalBim, uraian, true);
            rf.Text = "Data Record Bimbingan";
            rf.ShowDialog();
            refR();
        }

        private void searchTaTB_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT 'TA ID' = TaId, 'Judul Tugas Akhir' = Judul, 'Tahun' = FORMAT(Tahun, 'yyyy'), Semester, 'Tanggal Mulai' = TanggalMulai, 'Tanggal Batas' = TanggalBatas FROM TA.TugasAkhir WHERE Judul LIKE '%'+@text+'%' OR Tahun LIKE @text+'%'";
            taDataGridView.DataSource = p.searchTampil(query, "text", searchTaTB.Text);
            taDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            taDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchMhsTB_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT m.NIM, 'Nama Mahasiswa' = m.NamaMhs, Asal, 'No Telepon' = m.Notel, 'Tugas Akhir' = ta.Judul FROM Orang.Mahasiswa m JOIN TA.TugasAkhir ta ON m.TaID = ta.TaID WHERE m.NamaMhs LIKE '%'+@text+'%' OR m.NIM LIKE '%'+@text+'%'";
            mahasiswaDataGridView.DataSource = p.searchTampil(query, "text", searchMhsTB.Text);
            mahasiswaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchRecBT_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT 'Nomor' = a.No, 'Nama Mahasiswa' = b.NamaMhs, 'Tanggal Bimbingan' = a.TanggalBimbingan, a.Uraian FROM TA.Bimbingan a JOIN Orang.Mahasiswa b ON a.NIM = b.NIM WHERE b.NamaMhs LIKE '%'+@text+'%' OR a.TanggalBimbingan LIKE @text+'%'";
            recordDataGridView.DataSource = p.searchTampil(query, "text", searchRecBT.Text);
            recordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchDsnTB_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT NIK, 'Nama Dosen' = NamaDsn, 'Nomor Telepon' = Notel FROM Orang.Dosen WHERE NamaDsn LIKE '%'+@text+'%' OR NIK LIKE @text+'%'";
            dosenDataGridView.DataSource = p.searchTampil(query, "text", searchDsnTB.Text);
            dosenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void exportToPdf(DataGridView dgv, string filename)
        {
            TungguForm tuf = new TungguForm();
            tuf.Show();
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dgv.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            tuf.Close();
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 50f, 50f, 50f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void savePdfBtn_Click(object sender, EventArgs e)
        {
            exportToPdf(dosenDataGridView, "Data Dosen");
        }

        private void exportToExcel(DataGridView dataGridView, string filename)
        {

            TungguForm tuf = new TungguForm();
            tuf.Show();
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dataGridView.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            tuf.Close();
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".xlsx";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(savefiledialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void saveDsnExBtn_Click(object sender, EventArgs e)
        {
            exportToExcel(dosenDataGridView, "Data Dosen");
        }

        private void saveRecPdfBtn_Click(object sender, EventArgs e)
        {
            exportToPdf(recordDataGridView, "Data Record Monitoring Tugas Akhir");
        }

        private void saveRecExBtn_Click(object sender, EventArgs e)
        {
            exportToExcel(recordDataGridView, "Data Record Monitoring Tugas Akhir");
        }

        private void saveTaPdfBtn_Click(object sender, EventArgs e)
        {
            exportToPdf(taDataGridView, "Data Tugas Akhir");
        }

        private void saveTaExBtn_Click(object sender, EventArgs e)
        {
            exportToExcel(taDataGridView, "Data Tugas Akhir");
        }

        private void saveMhsPdfBtn_Click(object sender, EventArgs e)
        {
            exportToPdf(mahasiswaDataGridView, "Data Mahasiswa");
        }

        private void saveMhsExBtn_Click(object sender, EventArgs e)
        {
            exportToExcel(mahasiswaDataGridView, "Data Mahasiswa");
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
