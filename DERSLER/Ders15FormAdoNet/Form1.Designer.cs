
namespace Ders15FormAdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ekle = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.lblSil = new System.Windows.Forms.Label();
            this.cmbSil = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTCUpdate = new System.Windows.Forms.TextBox();
            this.txtTelefonUpdate = new System.Windows.Forms.TextBox();
            this.txtSoyadUpdate = new System.Windows.Forms.TextBox();
            this.txtAdUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabListele = new System.Windows.Forms.TabPage();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Ekle.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabGuncelle.SuspendLayout();
            this.tabListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ekle);
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabGuncelle);
            this.tabControl1.Controls.Add(this.tabListele);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 373);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.White;
            this.Ekle.Controls.Add(this.label1);
            this.Ekle.Controls.Add(this.btnEkle);
            this.Ekle.Controls.Add(this.txtTc);
            this.Ekle.Controls.Add(this.txtTelephone);
            this.Ekle.Controls.Add(this.txtSoyad);
            this.Ekle.Controls.Add(this.txtAd);
            this.Ekle.Controls.Add(this.lblTc);
            this.Ekle.Controls.Add(this.lblTelephone);
            this.Ekle.Controls.Add(this.lblSoyad);
            this.Ekle.Controls.Add(this.lblAd);
            this.Ekle.Location = new System.Drawing.Point(4, 24);
            this.Ekle.Name = "Ekle";
            this.Ekle.Padding = new System.Windows.Forms.Padding(3);
            this.Ekle.Size = new System.Drawing.Size(741, 345);
            this.Ekle.TabIndex = 0;
            this.Ekle.Text = "Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğrenci Ekleme";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEkle.Location = new System.Drawing.Point(144, 229);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(197, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(144, 183);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(197, 23);
            this.txtTc.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(144, 151);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(197, 23);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(144, 120);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(197, 23);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(144, 88);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(197, 23);
            this.txtAd.TabIndex = 4;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTc.Location = new System.Drawing.Point(94, 188);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(38, 19);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "TC : ";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelephone.Location = new System.Drawing.Point(71, 156);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(70, 19);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "Telefon : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyad.Location = new System.Drawing.Point(82, 124);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 19);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad : ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAd.Location = new System.Drawing.Point(97, 88);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(40, 19);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad : ";
            // 
            // tabEkle
            // 
            this.tabEkle.Controls.Add(this.lblSil);
            this.tabEkle.Controls.Add(this.cmbSil);
            this.tabEkle.Controls.Add(this.btnSil);
            this.tabEkle.Location = new System.Drawing.Point(4, 24);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(741, 345);
            this.tabEkle.TabIndex = 1;
            this.tabEkle.Text = "Sil";
            this.tabEkle.UseVisualStyleBackColor = true;
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSil.Location = new System.Drawing.Point(202, 80);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(280, 21);
            this.lblSil.TabIndex = 2;
            this.lblSil.Text = "Silinecek öğrenciyi listeden seçiniz.";
            // 
            // cmbSil
            // 
            this.cmbSil.FormattingEnabled = true;
            this.cmbSil.Location = new System.Drawing.Point(202, 130);
            this.cmbSil.Name = "cmbSil";
            this.cmbSil.Size = new System.Drawing.Size(280, 23);
            this.cmbSil.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(202, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(280, 53);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.BackColor = System.Drawing.Color.Silver;
            this.tabGuncelle.Controls.Add(this.cmbUpdate);
            this.tabGuncelle.Controls.Add(this.label7);
            this.tabGuncelle.Controls.Add(this.label2);
            this.tabGuncelle.Controls.Add(this.btnGuncelle);
            this.tabGuncelle.Controls.Add(this.txtTCUpdate);
            this.tabGuncelle.Controls.Add(this.txtTelefonUpdate);
            this.tabGuncelle.Controls.Add(this.txtSoyadUpdate);
            this.tabGuncelle.Controls.Add(this.txtAdUpdate);
            this.tabGuncelle.Controls.Add(this.label3);
            this.tabGuncelle.Controls.Add(this.label4);
            this.tabGuncelle.Controls.Add(this.label5);
            this.tabGuncelle.Controls.Add(this.label6);
            this.tabGuncelle.Location = new System.Drawing.Point(4, 24);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Size = new System.Drawing.Size(741, 345);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelle";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(25, 126);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(287, 23);
            this.cmbUpdate.TabIndex = 21;
            this.cmbUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbUpdate_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Düzenlenecek öğrenciyi listeden seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(291, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Öğrenci Güncelleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.Red;
            this.btnGuncelle.Location = new System.Drawing.Point(448, 203);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(234, 40);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // txtTCUpdate
            // 
            this.txtTCUpdate.Location = new System.Drawing.Point(448, 157);
            this.txtTCUpdate.Name = "txtTCUpdate";
            this.txtTCUpdate.Size = new System.Drawing.Size(234, 23);
            this.txtTCUpdate.TabIndex = 17;
            // 
            // txtTelefonUpdate
            // 
            this.txtTelefonUpdate.Location = new System.Drawing.Point(448, 125);
            this.txtTelefonUpdate.Name = "txtTelefonUpdate";
            this.txtTelefonUpdate.Size = new System.Drawing.Size(234, 23);
            this.txtTelefonUpdate.TabIndex = 16;
            // 
            // txtSoyadUpdate
            // 
            this.txtSoyadUpdate.Location = new System.Drawing.Point(448, 94);
            this.txtSoyadUpdate.Name = "txtSoyadUpdate";
            this.txtSoyadUpdate.Size = new System.Drawing.Size(234, 23);
            this.txtSoyadUpdate.TabIndex = 15;
            // 
            // txtAdUpdate
            // 
            this.txtAdUpdate.Location = new System.Drawing.Point(448, 62);
            this.txtAdUpdate.Name = "txtAdUpdate";
            this.txtAdUpdate.Size = new System.Drawing.Size(234, 23);
            this.txtAdUpdate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(398, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "TC : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(375, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefon : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(386, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soyad : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(401, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ad : ";
            // 
            // tabListele
            // 
            this.tabListele.Controls.Add(this.dgwOgrenciler);
            this.tabListele.Location = new System.Drawing.Point(4, 24);
            this.tabListele.Name = "tabListele";
            this.tabListele.Size = new System.Drawing.Size(741, 345);
            this.tabListele.TabIndex = 3;
            this.tabListele.Text = "Listele";
            this.tabListele.UseVisualStyleBackColor = true;
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(13, 15);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.RowTemplate.Height = 25;
            this.dgwOgrenciler.Size = new System.Drawing.Size(709, 291);
            this.dgwOgrenciler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ekle.ResumeLayout(false);
            this.Ekle.PerformLayout();
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabGuncelle.ResumeLayout(false);
            this.tabGuncelle.PerformLayout();
            this.tabListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ekle;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.TabPage tabGuncelle;
        private System.Windows.Forms.TabPage tabListele;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.ComboBox cmbSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTCUpdate;
        private System.Windows.Forms.TextBox txtTelefonUpdate;
        private System.Windows.Forms.TextBox txtSoyadUpdate;
        private System.Windows.Forms.TextBox txtAdUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.Label label7;
    }
}

