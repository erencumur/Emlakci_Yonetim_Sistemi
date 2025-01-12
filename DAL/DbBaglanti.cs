using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using static System.Net.Mime.MediaTypeNames;
using System.IO;



namespace DAL
{
    public class DbBaglanti
    {
        // Veritabanı bağlantısını sağlayan metot
        public OleDbConnection GetConnection()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmlakciDB.accdb");
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
            // OleDbConnection nesnesi döndür
            return new OleDbConnection(connectionString);
        }


    }
}
