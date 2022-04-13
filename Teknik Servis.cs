using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Personel personel = db.Personel.Where(x => x.Email == txt_Email.Text && x.Sifre == txt_sifre.Text).SingleOrDefault();
            if (personel == null)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız, Tekrar Deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Program.personel = personel;
                new FrmAnasayfa().Show();
                this.Hide();




            }
        }
    }
}
