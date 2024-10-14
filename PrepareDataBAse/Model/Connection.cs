using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareDataBAse.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataSet ds;
        public MySqlConnection Conn;

        /*cmd: Objek MySqlCommand untuk menjalankan perintah SQL ke database.
        da: Objek MySqlDataAdapter digunakan untuk mengambil data dan mengisi dataset (DataSet).
        ds: Objek DataSet, yang digunakan untuk menyimpan data dari database dalam bentuk tabel.
        Conn: Objek MySqlConnection, yang berfungsi sebagai koneksi ke database MySQL.*/

        public MySqlConnection GetConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;user=root;database=db_perpus";

            try
            {
                Conn.Open();
                /*Conn.Open(): Membuka koneksi ke database MySQL. Jika koneksi berhasil, koneksi tetap terbuka dan siap digunakan.*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal" + ex.Message);
            }
            return Conn;
        }
    }
}

