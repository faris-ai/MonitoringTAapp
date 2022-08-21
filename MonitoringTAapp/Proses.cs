using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringTAapp
{
    class Proses
    {
        string strKoneksi = "Data Source=DESKTOP-FARISAI;Initial Catalog=MonitoringTA;Persist Security Info=True;User ID=sa;Password=1234567890";
        public DataTable selectQuery(string query)
        {
            DataTable dt = new DataTable();;
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            sqlData.Fill(dt);

            koneksi.Close();
            return dt;
        }


        /// <summary>
        /// Ini adalah contoh Overloading
        /// Overloading adalah suatu method yang menggunakan nama yang sama pada sebuah kelas, 
        /// namun parameter dan return type methodnya berbeda
        /// </summary>
        public DataTable searchTampil(string query, string para, string text)
        {
            DataTable dt = new DataTable(); ;
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter(para, text));
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            sqlData.Fill(dt);

            koneksi.Close();
            return dt;
        }

        public DataTable searchTampil(string query, string para, string text, int no)
        {
            DataTable dt = new DataTable(); ;

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter(para, text+no));
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            sqlData.Fill(dt);

            koneksi.Close();
            return dt;
        }

        public List<string> tampilCB(string query)
        {
            List<string> ls = new List<string>();
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            { 
                ls.Add(dataReader.GetString(0));
            }

            koneksi.Close();
            return ls;
        }

        public List<DateTime> ambilTggl(string query)
        {
            List<DateTime> ls = new List<DateTime>();
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                ls.Add(dataReader.GetDateTime(0));
                ls.Add(dataReader.GetDateTime(1));
            }

            koneksi.Close();
            return ls;
        }

        public void insertDataTA(int id, string judul, string tahun, string semester, string timeM, string timeB, bool isEdit)
        {
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string query;

            if (isEdit)
                query = "UPDATE TA.TugasAkhir SET Judul = @jdl, Tahun = @thn, Semester = @smstr, TanggalMulai = @tm, TanggalBatas = @tb WHERE TaId = @id";
            else
                query = "INSERT INTO TA.TugasAkhir (TaId, Judul, Tahun, Semester, TanggalMulai, TanggalBatas) VALUES(@id, @jdl, @thn, @smstr, @tm, @tb)";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("jdl", judul));
            cmd.Parameters.Add(new SqlParameter("thn", tahun));
            cmd.Parameters.Add(new SqlParameter("smstr", semester));
            cmd.Parameters.Add(new SqlParameter("tm", timeM));
            cmd.Parameters.Add(new SqlParameter("tb", timeB));
            cmd.ExecuteNonQuery();

            koneksi.Close();
        }

        public void hapusDataTA(int id)
        {
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string query;

            query = "DELETE FROM TA.TugasAkhir WHERE TaId = @id";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Data tugas akhir ini telah digunakan di data mahasiswa\n\nHapus terlebih dahulu data mahasiswa yang berkaitan dengan data ini", "TUNGGU", 
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            koneksi.Close();
        }

        public void insertDataMhs(string nim, string nama, string asal, string notel, string judul, bool isEdit)
        {
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string query;

            if (isEdit)
                query = "UPDATE Orang.Mahasiswa SET NamaMhs = @nm, Asal = @asl, Notel = @tel, TaId = (SELECT TaId FROM TA.TugasAkhir WHERE Judul = @jdl) WHERE NIM = @nim";
            else
                query = "INSERT INTO Orang.Mahasiswa (NIM, NamaMhs, Asal, Notel, TaId) SELECT @nim, @nm, @asl, @tel, TaId FROM TA.TugasAkhir WHERE Judul = @jdl";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("nim", nim));
            cmd.Parameters.Add(new SqlParameter("nm", nama));
            cmd.Parameters.Add(new SqlParameter("asl", asal));
            cmd.Parameters.Add(new SqlParameter("tel", notel));
            cmd.Parameters.Add(new SqlParameter("jdl", judul));
            try
            {
                cmd.ExecuteNonQuery();
            } catch (Exception e)
            {
                DialogResult dr = MessageBox.Show("NIM yang digunakan sama dengan NIM yang telah ada", "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


            koneksi.Close();
        }

        public void hapusDataMhs(string nim)
        {
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string query;

            query = "DELETE FROM Orang.Mahasiswa WHERE NIM = @nim";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("nim", nim));
            try
            {
                cmd.ExecuteNonQuery();
            } catch
            {
                DialogResult dr = MessageBox.Show("Data mahasiswa ini telah digunakan di data record bimbingan\n\nHapus terlebih dahulu data record bimbingan yang berkaitan dengan data ini", 
                    "TUNGGU", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


            koneksi.Close();
        }

        public void insertDataBim(int no, string namaMhs, string namaDsn, string tgglB, string urai, bool isEdit)
        {
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string query;
            if (isEdit)
                query = "UPDATE TA.Bimbingan SET NIM = (SELECT NIM FROM Orang.Mahasiswa WHERE NamaMhs = @nm), NIK = (SELECT NIK FROM Orang.Dosen WHERE NamaDsn = @nd), " +
                    "TanggalBimbingan = @tb, Uraian = @ur WHERE No = @no";
            else
                query = "INSERT INTO TA.Bimbingan (No, NIM, NIK, TanggalBimbingan, Uraian) SELECT @no, a.NIM, b.NIK, @tb, @ur FROM Orang.Mahasiswa a CROSS JOIN " +
                    "Orang.Dosen b WHERE a.NamaMhs = @nm AND b.NamaDsn = @nd";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("no", no));
            cmd.Parameters.Add(new SqlParameter("nm", namaMhs));
            cmd.Parameters.Add(new SqlParameter("nd", namaDsn));
            cmd.Parameters.Add(new SqlParameter("tb", tgglB));
            cmd.Parameters.Add(new SqlParameter("ur", urai));
            cmd.ExecuteNonQuery();

            koneksi.Close();
        }

        public bool hapusDataBim(int id)
        {
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string query;

            query = "DELETE FROM TA.Bimbingan WHERE No = @no";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("no", id));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            return true;
        }

        public string tampilNama(string query, string para, string id)
        {
            string nama = "";
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter(para, id));
            cmd.ExecuteNonQuery();

            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            try
            {
                nama = dataReader.GetString(0);
            } catch
            {
                try
                {
                    nama = dataReader.GetInt32(0).ToString();
                } catch
                {
                    nama = dataReader.GetDateTime(0).ToString();
                }
            }

            koneksi.Close();
            return nama;
        }

        public bool isDataSamaAda(string query, string para, string text)
        {
            bool isOk = true;
            
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter(para, text));
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                dataReader.GetString(0);
            } catch
            {
                isOk = false;
            }
            koneksi.Close();
            return isOk;
        }
    }
}