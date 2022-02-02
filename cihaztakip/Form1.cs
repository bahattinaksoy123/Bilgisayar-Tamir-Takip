using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cihaztakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }


       


        private void Button_personel_giris_Click_1(object sender, EventArgs e)
        {

            try
            {
               bool sayimi = false;
                int i1 = 0;
                int i = 0;
                foreach (char a in txt_personel_tc.Text)
                {
                    i1++;
                    if (Char.IsDigit(a))
                    {
                        i++;
                    }
                    else break;
                }

                if (i1 == 11 && i == 11)
                {
                    if (new dao.personel().personelkontrol(txt_personel_tc.Text, txt_personel_parola.Text))
                    {
                        this.Hide();
                        new frm_cihaztursec().Show();
                    }
                    else
                    {
                        MessageBox.Show("Giriş işlemi Başarısız");

                    }
                }

                else MessageBox.Show("Tc 11 haneli olmalıdır ve yalnızca rakamlardan oluşabilir !!!");
            }
            catch
            {
                MessageBox.Show("HATA giris 404!!");

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }








        ///////////////////////////////////////////////////////////////////////////
    }
}
