using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cihaztakip
{
    public partial class frm_cihaztursec : Form
    {
        bool subevarmi;

        public frm_cihaztursec()
        {
            InitializeComponent();
        }

        private void Btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show(); 
        }

       

        private void Btn_cihaztur_ekle_Click(object sender, EventArgs e)
        {
           // new classes.cihaztur { cihazisim = txt_cihazturisim_ekle.Text; cihazkod };
            
        }

        private void Frm_cihaztursec_Load(object sender, EventArgs e)
        {
            flowlayoutpaneldoldur();
        }


        public void flowlayoutpaneldoldur()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            DataTable table = new DataTable();
            table = new dao.cihaz().cihazturleri();
            if (table != null)
            {
                DataRowCollection collection = table.Rows;
                foreach (DataRow row in collection)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = row["urun_tip_ID"].ToString()+ "*" + row["usturun_tip_kod"].ToString();
                    
                    pictureBox.Size = new Size(338, 296);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Image = global::cihaztakip.Properties.Resources._327_512;
                    pictureBox.Click += pb_cihaztur_Click;
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }
            else MessageBox.Show("Cihaz Türü Bulunamadı");

        }

        private void pb_cihaztur_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            panel_cihazinfo_gir.Visible = true;
            pb_secilencihaz.Visible = true;
            pb_secilencihaz.Image = global::cihaztakip.Properties.Resources._327_512;

            string cihaz_tip_kod = (((sender as PictureBox).Name).ToString()).Split('*')[1];
            panel_cihazinfo_gir_doldur(cihaz_tip_kod);

        }

       public void panel_cihazinfo_gir_doldur(string cihaz_tip_kod)
        {
            label_uruntipkod.Text = cihaz_tip_kod;
            //////////////////////////////////////////////////////////////////////      //  label_subekod=info.personel
            ///
            iller_doldur();
          
        }

        private void iller_doldur()
        {
            c_il.Items.Clear();   
            DataTable table = new DataTable();
            table = new dao.yer().iller();
            if (table != null)
            {
                DataRowCollection collection = table.Rows;
                int il_sayi = collection.Count;
                string[] iller = new string[il_sayi];
                int i = 0;
                foreach (DataRow row in collection)
                {
                    // c_il.Items.Add(row["il"].ToString());
                    iller[i] = row["il"] + "*" + row["il_kod"];
                    i++;
                }


                for(int i1 = 0; i1 < collection.Count-1; i1++)
                {
                    for (int i2 = 0; i2 < collection.Count-1; i2++)
                    {
                        if(int.Parse(iller[i2].Split('*')[1]) > int.Parse(iller[i2 + 1].Split('*')[1]))
                        {
                            string temp = iller[i2];
                            iller[i2] = iller[i2 + 1];
                            iller[i2 + 1] = temp;
                        }


                    }
                }

                foreach(string il in iller)
                {
                    c_il.Items.Add(il.Split('*')[0]);
                }

              

            }
            else
            {
                MessageBox.Show("İller bulunamadı !!");
            }

        }

        private void binalar_doldur()
        {
            c_bina.Items.Clear();
            DataTable table = new DataTable();
            table = new dao.yer().binalar(c_il.Text);
            if (table != null)
            {
                DataRowCollection collection = table.Rows;
                
                foreach (DataRow row in collection)
                {
                    c_bina.Items.Add(row["bina_isim"].ToString());
                   
                }

            }
        }


        private void sube_doldur()
        {
            c_sube.Items.Clear();
            DataTable table = new DataTable();

            new info.yer_bina() { Il = c_il.Text, Bina_isim = c_bina.Text };

            table = new dao.yer().subeler(c_il.Text,c_bina.Text);
            if (table != null)
            {
                DataRowCollection collection = table.Rows;

                foreach (DataRow row in collection)
                {
                    c_sube.Items.Add(row["alt_sube_ad"].ToString());

                }

            }
        }



        private void Btn_cihazturekle_visible_Click(object sender, EventArgs e)
        {
            btn_cihazturekle_visible.Visible = false;
            panel_cihazturekle.Visible = true;
        }

        private void Btn_cihazturekle_iptal_Click(object sender, EventArgs e)
        {
            panel_cihazturekle.Visible = false;
            btn_cihazturekle_visible.Visible = true;
        }

        private void Btn_cihaztur_resim_sec_Click(object sender, EventArgs e)
        {
            
                openFileDialog1.ShowDialog();
                pb_cihazturekle.ImageLocation = openFileDialog1.FileName;
                label12.Text = openFileDialog1.FileName;

            
        }

        private void Btn_yenicihazekle_Click(object sender, EventArgs e)
        {
            panel_cihazekle.Visible = true;
            panel_cihazinfo_gir.Visible = false;

        }

        private void Btn_cihazedit_girmemek_Click(object sender, EventArgs e)
        {
            panel_cihazinfo_gir.Visible = false;
            pb_secilencihaz.Visible = false;
            flowlayoutpaneldoldur();
        }

        private void Btn_cihazekle_iptal_Click(object sender, EventArgs e)
        {
            panel_cihazekle.Visible = false;
            pb_secilencihaz.Visible = false;
            flowlayoutpaneldoldur();
        }

        private void Btn_cihazaciklama_ekle_Click(object sender, EventArgs e)
        {
            panel_aciklamaekle.Visible = true;
        }

        private void C_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*//MessageBox.Show(((sender as ComboBox).SelectedIndex + 1).ToString());



            binalar_doldur();
        }

        private void C_il_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] il_keypres = new string[c_il.Items.Count];
            int ba = 0;
            foreach(string b in c_il.Items)
            {
                for (int i = 0; i < c_il.Text.Length; i++)
                {
                    foreach(char cc in c_il.Text)
                    {
                        foreach (char cb in b)
                        {
                            if (cb == cc)
                            {
                                il_keypres[ba] = b;
                                ba++;
                            }
                    }
                    }
                   
                }
            }


            c_il.Items.Clear();
            foreach(string ab in il_keypres){
                c_il.Items.Add(ab);
            }

        }

        private void Panel_cihazinfo_gir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void C_bina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(new dao.yer().subevarmi(c_il.Text, c_bina.Text))
            {
                c_sube.Visible = true;
                lbl_subeyok.Visible = false;
                subevarmi = true;
                sube_doldur();
            }
            else
            {
                lbl_subeyok.Visible = true;
                c_sube.Visible = false;

                subevarmi = false;

            }
        }

        private void C_sube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





















        ///////////////////////////////////////
    }
}
