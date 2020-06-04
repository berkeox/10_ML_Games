using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecmenSapka
{
    public class SoruEkle_Class
    {
        readonly Database db = new Database();

        public void SoruKaydet(string soru, string Asıkkı, string Bsıkkı, string Csıkkı, string Dsıkkı)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Soru values(@soru,@Asıkkı,@Bsıkkı,@Csıkkı,@Dsıkkı)", db.baglanti);
                ekle.Parameters.AddWithValue("@soru", soru);
                ekle.Parameters.AddWithValue("@Asıkkı", Asıkkı);
                ekle.Parameters.AddWithValue("@Bsıkkı", Bsıkkı);
                ekle.Parameters.AddWithValue("@Csıkkı", Csıkkı);
                ekle.Parameters.AddWithValue("@Dsıkkı", Dsıkkı);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Soru  eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ekle.Dispose();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
