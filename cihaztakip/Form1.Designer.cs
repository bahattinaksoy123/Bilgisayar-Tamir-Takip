namespace cihaztakip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_personel_tc = new System.Windows.Forms.TextBox();
            this.txt_personel_parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_personel_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::cihaztakip.Properties.Resources.cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1135, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txt_personel_tc
            // 
            this.txt_personel_tc.Location = new System.Drawing.Point(308, 671);
            this.txt_personel_tc.Name = "txt_personel_tc";
            this.txt_personel_tc.Size = new System.Drawing.Size(189, 20);
            this.txt_personel_tc.TabIndex = 1;
            // 
            // txt_personel_parola
            // 
            this.txt_personel_parola.Location = new System.Drawing.Point(816, 671);
            this.txt_personel_parola.Name = "txt_personel_parola";
            this.txt_personel_parola.Size = new System.Drawing.Size(170, 20);
            this.txt_personel_parola.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PERSONEL TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD : ";
            // 
            // button_personel_giris
            // 
            this.button_personel_giris.BackColor = System.Drawing.Color.GreenYellow;
            this.button_personel_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personel_giris.FlatAppearance.BorderSize = 0;
            this.button_personel_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_personel_giris.Location = new System.Drawing.Point(515, 754);
            this.button_personel_giris.Name = "button_personel_giris";
            this.button_personel_giris.Size = new System.Drawing.Size(151, 23);
            this.button_personel_giris.TabIndex = 5;
            this.button_personel_giris.Text = "GİRİŞ";
            this.button_personel_giris.UseVisualStyleBackColor = false;
            this.button_personel_giris.Click += new System.EventHandler(this.Button_personel_giris_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cihaztakip.Properties.Resources.giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 819);
            this.Controls.Add(this.button_personel_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_personel_parola);
            this.Controls.Add(this.txt_personel_tc);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_personel_tc;
        private System.Windows.Forms.TextBox txt_personel_parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_personel_giris;
    }
}

