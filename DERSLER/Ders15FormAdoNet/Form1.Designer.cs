
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
            this.tabListele = new System.Windows.Forms.TabPage();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Ekle.SuspendLayout();
            this.tabEkle.SuspendLayout();
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
            this.tabGuncelle.Location = new System.Drawing.Point(4, 24);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Size = new System.Drawing.Size(741, 345);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelle";
            this.tabGuncelle.UseVisualStyleBackColor = true;
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
            this.dgwOgrenciler.Location = new System.Drawing.Point(14, 19);
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
    }
}

