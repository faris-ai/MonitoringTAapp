using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MonitoringTAapp
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void isSamaData()
        {
            Proses p = new Proses();
            Assert.AreEqual(true, p.isDataSamaAda("SELECT Judul FROM TA.TugasAkhir WHERE TaId = @ti", "ti", "100"));
        }

        [TestCase]
        public void tampilNama()
        {
            Proses p = new Proses();
            Assert.AreEqual("20170140101", p.tampilNama("SELECT NIM FROM Orang.Mahasiswa WHERE NamaMhs = @nm", "nm", "Tossy Santoso"));
            Assert.AreEqual("Genap", p.tampilNama("SELECT Semester FROM TA.TugasAkhir WHERE TaId = " +
                "(SELECT TaId FROM Orang.Mahasiswa WHERE NIM = @nim)", "nim", "20170140101")); 
        }

        [TestCase]
        public void hapusDataBim()
        {
            Proses p = new Proses();
            Assert.AreEqual(true, p.hapusDataBim(5001));
        }
    }
}
