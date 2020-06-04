using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecmenSapka
{
    public partial class TrainForm : Form
    {
        public TrainForm()
        {
            InitializeComponent();
        }

        private void Ekle_Btn_Click(object sender, EventArgs e)
        {

            if (Soru_textBox.Text == string.Empty || Asıkkı_textBox.Text == string.Empty || Bsıkkı_textBox.Text == string.Empty || Csıkkı_textBox.Text == string.Empty || Dsıkkı_textBox.Text == string.Empty)
            {
                MessageBox.Show("Lütfen her alanı doldurduğunuza emin olunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SoruEkle_Class soru = new SoruEkle_Class();
                soru.SoruKaydet(Soru_textBox.Text, Asıkkı_textBox.Text, Bsıkkı_textBox.Text, Csıkkı_textBox.Text, Dsıkkı_textBox.Text);
                foreach (Control item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void Geri_pictureBox_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }
    }
}
