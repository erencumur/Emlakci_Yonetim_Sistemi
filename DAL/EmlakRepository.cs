using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class EmlakRepository
    {
        private DbBaglanti dbBaglanti = new DbBaglanti();

        public List<Emlak> GetAllProperties()
        {
            List<Emlak> emlakList = new List<Emlak>();
            string query = "SELECT * FROM Emlak";

            using (OleDbConnection conn = dbBaglanti.GetConnection())
            {

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable); 

                foreach (DataRow row in dataTable.Rows)
                {
                    Emlak emlak = new Emlak
                    {

                        MulkTipi = row["MulkTipi"].ToString(),
                        Adres = row["Adres"].ToString(),
                        Fiyat = row["Fiyat"] != DBNull.Value ? Convert.ToDouble(row["Fiyat"]) : 0.0,
                        OdaSayisi = row["OdaSayisi"] != DBNull.Value ? Convert.ToInt32(row["OdaSayisi"]) : 0,
                        Metrekare = row["Metrekare"] != DBNull.Value ? Convert.ToDouble(row["Metrekare"]) : 0.0,
                        BulunduguKat = row["BulunduguKat"] != DBNull.Value ? Convert.ToInt32(row["BulunduguKat"]) : 0,
                        ToplamKatSayisi = row["ToplamKatSayisi"] != DBNull.Value ? Convert.ToInt32(row["ToplamKatSayisi"]) : 0
                    };
                    emlakList.Add(emlak);
                }
            }

            return emlakList;
        }
        public void DeleteEmlak(string adres)
        {
            using (OleDbConnection conn = dbBaglanti.GetConnection())
            {
                string query = "DELETE FROM emlak WHERE Adres = @Adres";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Adres", adres);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void AddEmlak(Emlak yeniEmlak)
        {
            using (OleDbConnection conn = dbBaglanti.GetConnection())
            {
                string query = "INSERT INTO Emlak (MulkTipi, Adres, Fiyat, OdaSayisi, Metrekare,ToplamKatSayisi,BulunduguKat) VALUES (@MulkTipi, @Adres, @Fiyat, @OdaSayisi, @Metrekare,@ToplamKatSayisi,@BulunduguKat)";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("@MulkTipi", yeniEmlak.MulkTipi);
                cmd.Parameters.AddWithValue("@Adres", yeniEmlak.Adres);
                cmd.Parameters.AddWithValue("@Fiyat", yeniEmlak.Fiyat);
                cmd.Parameters.AddWithValue("@OdaSayisi", yeniEmlak.OdaSayisi);
                cmd.Parameters.AddWithValue("@Metrekare", yeniEmlak.Metrekare);
                cmd.Parameters.AddWithValue("@ToplamKatSayisi", yeniEmlak.ToplamKatSayisi); // Yeni sütun
                cmd.Parameters.AddWithValue("@BulunduguKat", yeniEmlak.BulunduguKat); // Yeni sütun
                

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateEmlak(string eskiAdres, Emlak emlak)
        {
            using (OleDbConnection conn = dbBaglanti.GetConnection())
            {
                string query = "UPDATE emlak SET MulkTipi = @MulkTipi, Adres = @YeniAdres, Fiyat = @Fiyat, OdaSayisi = @OdaSayisi, Metrekare = @Metrekare, BulunduguKat = @BulunduguKat, ToplamKatSayisi = @ToplamKatSayisi WHERE Adres = @EskiAdres";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("@MulkTipi", emlak.MulkTipi);
                cmd.Parameters.AddWithValue("@YeniAdres", emlak.Adres);
                cmd.Parameters.AddWithValue("@Fiyat", emlak.Fiyat);
                cmd.Parameters.AddWithValue("@OdaSayisi", emlak.OdaSayisi);
                cmd.Parameters.AddWithValue("@Metrekare", emlak.Metrekare);
                cmd.Parameters.AddWithValue("@BulunduguKat", emlak.BulunduguKat);
                cmd.Parameters.AddWithValue("@ToplamKatSayisi", emlak.ToplamKatSayisi);
                cmd.Parameters.AddWithValue("@EskiAdres", eskiAdres);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
    
}
