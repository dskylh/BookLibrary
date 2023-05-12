
namespace Mbp_104_Proje
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpKitapEkleme = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlKitapSil = new System.Windows.Forms.Panel();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.cbxYazarSil = new System.Windows.Forms.CheckBox();
            this.txtKitapSilYazar = new System.Windows.Forms.TextBox();
            this.lblKitapSilYazar = new System.Windows.Forms.Label();
            this.txtKitapSilIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTarihleriKaydetme = new System.Windows.Forms.RadioButton();
            this.rdbTarihiKaydet = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.dtpBaslama = new System.Windows.Forms.DateTimePicker();
            this.lblBaslama = new System.Windows.Forms.Label();
            this.sayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.lblKitapPuani = new System.Windows.Forms.Label();
            this.cmbPuan = new System.Windows.Forms.ComboBox();
            this.txtKitapIsmi = new System.Windows.Forms.TextBox();
            this.lblKitapIsmi = new System.Windows.Forms.Label();
            this.tbpKitapListe = new System.Windows.Forms.TabPage();
            this.dgvKitapListe = new System.Windows.Forms.DataGridView();
            this.btnDgvListele = new System.Windows.Forms.Button();
            this.lbxIstatistik = new System.Windows.Forms.ListBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tbpKitapEkleme.SuspendLayout();
            this.pnlKitapSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisi)).BeginInit();
            this.tbpKitapListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpKitapEkleme);
            this.tabControl1.Controls.Add(this.tbpKitapListe);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 359);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbpKitapEkleme
            // 
            this.tbpKitapEkleme.Controls.Add(this.label2);
            this.tbpKitapEkleme.Controls.Add(this.pnlKitapSil);
            this.tbpKitapEkleme.Controls.Add(this.rdbTarihleriKaydetme);
            this.tbpKitapEkleme.Controls.Add(this.rdbTarihiKaydet);
            this.tbpKitapEkleme.Controls.Add(this.btnEkle);
            this.tbpKitapEkleme.Controls.Add(this.txtYazar);
            this.tbpKitapEkleme.Controls.Add(this.lblYazar);
            this.tbpKitapEkleme.Controls.Add(this.dtpBitis);
            this.tbpKitapEkleme.Controls.Add(this.lblBitis);
            this.tbpKitapEkleme.Controls.Add(this.dtpBaslama);
            this.tbpKitapEkleme.Controls.Add(this.lblBaslama);
            this.tbpKitapEkleme.Controls.Add(this.sayfaSayisi);
            this.tbpKitapEkleme.Controls.Add(this.lblSayfaSayisi);
            this.tbpKitapEkleme.Controls.Add(this.lblKitapPuani);
            this.tbpKitapEkleme.Controls.Add(this.cmbPuan);
            this.tbpKitapEkleme.Controls.Add(this.txtKitapIsmi);
            this.tbpKitapEkleme.Controls.Add(this.lblKitapIsmi);
            this.tbpKitapEkleme.Location = new System.Drawing.Point(4, 22);
            this.tbpKitapEkleme.Name = "tbpKitapEkleme";
            this.tbpKitapEkleme.Padding = new System.Windows.Forms.Padding(3);
            this.tbpKitapEkleme.Size = new System.Drawing.Size(484, 333);
            this.tbpKitapEkleme.TabIndex = 0;
            this.tbpKitapEkleme.Text = "Kitap Ekle/Sil";
            this.tbpKitapEkleme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kitap Ekle";
            // 
            // pnlKitapSil
            // 
            this.pnlKitapSil.Controls.Add(this.btnKitapSil);
            this.pnlKitapSil.Controls.Add(this.cbxYazarSil);
            this.pnlKitapSil.Controls.Add(this.txtKitapSilYazar);
            this.pnlKitapSil.Controls.Add(this.lblKitapSilYazar);
            this.pnlKitapSil.Controls.Add(this.txtKitapSilIsim);
            this.pnlKitapSil.Controls.Add(this.label3);
            this.pnlKitapSil.Controls.Add(this.label1);
            this.pnlKitapSil.Location = new System.Drawing.Point(264, 7);
            this.pnlKitapSil.Name = "pnlKitapSil";
            this.pnlKitapSil.Size = new System.Drawing.Size(214, 186);
            this.pnlKitapSil.TabIndex = 15;
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(6, 137);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(75, 23);
            this.btnKitapSil.TabIndex = 14;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // cbxYazarSil
            // 
            this.cbxYazarSil.AutoSize = true;
            this.cbxYazarSil.Location = new System.Drawing.Point(6, 113);
            this.cbxYazarSil.Name = "cbxYazarSil";
            this.cbxYazarSil.Size = new System.Drawing.Size(147, 17);
            this.cbxYazarSil.TabIndex = 13;
            this.cbxYazarSil.Text = "Yazarın Tüm Kitaplarını Sil";
            this.cbxYazarSil.UseVisualStyleBackColor = true;
            this.cbxYazarSil.CheckedChanged += new System.EventHandler(this.cbxYazarSil_CheckedChanged);
            // 
            // txtKitapSilYazar
            // 
            this.txtKitapSilYazar.Enabled = false;
            this.txtKitapSilYazar.Location = new System.Drawing.Point(6, 87);
            this.txtKitapSilYazar.Name = "txtKitapSilYazar";
            this.txtKitapSilYazar.Size = new System.Drawing.Size(121, 20);
            this.txtKitapSilYazar.TabIndex = 11;
            // 
            // lblKitapSilYazar
            // 
            this.lblKitapSilYazar.AutoSize = true;
            this.lblKitapSilYazar.Enabled = false;
            this.lblKitapSilYazar.Location = new System.Drawing.Point(3, 71);
            this.lblKitapSilYazar.Name = "lblKitapSilYazar";
            this.lblKitapSilYazar.Size = new System.Drawing.Size(71, 13);
            this.lblKitapSilYazar.TabIndex = 12;
            this.lblKitapSilYazar.Text = "Kitabın Yazarı";
            // 
            // txtKitapSilIsim
            // 
            this.txtKitapSilIsim.Location = new System.Drawing.Point(6, 47);
            this.txtKitapSilIsim.Name = "txtKitapSilIsim";
            this.txtKitapSilIsim.Size = new System.Drawing.Size(121, 20);
            this.txtKitapSilIsim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Sil";
            // 
            // rdbTarihleriKaydetme
            // 
            this.rdbTarihleriKaydetme.AutoSize = true;
            this.rdbTarihleriKaydetme.Location = new System.Drawing.Point(114, 278);
            this.rdbTarihleriKaydetme.Name = "rdbTarihleriKaydetme";
            this.rdbTarihleriKaydetme.Size = new System.Drawing.Size(112, 17);
            this.rdbTarihleriKaydetme.TabIndex = 14;
            this.rdbTarihleriKaydetme.Text = "Tarihleri Kaydetme";
            this.rdbTarihleriKaydetme.UseVisualStyleBackColor = true;
            // 
            // rdbTarihiKaydet
            // 
            this.rdbTarihiKaydet.AutoSize = true;
            this.rdbTarihiKaydet.Checked = true;
            this.rdbTarihiKaydet.Location = new System.Drawing.Point(9, 278);
            this.rdbTarihiKaydet.Name = "rdbTarihiKaydet";
            this.rdbTarihiKaydet.Size = new System.Drawing.Size(98, 17);
            this.rdbTarihiKaydet.TabIndex = 13;
            this.rdbTarihiKaydet.TabStop = true;
            this.rdbTarihiKaydet.Text = "Tarihleri Kaydet";
            this.rdbTarihiKaydet.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(9, 301);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(9, 94);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(121, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(6, 78);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(71, 13);
            this.lblYazar.TabIndex = 10;
            this.lblYazar.Text = "Kitabın Yazarı";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(9, 251);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 9;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(6, 235);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(55, 13);
            this.lblBitis.TabIndex = 8;
            this.lblBitis.Text = "Bitiş Tarihi";
            // 
            // dtpBaslama
            // 
            this.dtpBaslama.Location = new System.Drawing.Point(9, 212);
            this.dtpBaslama.Name = "dtpBaslama";
            this.dtpBaslama.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslama.TabIndex = 7;
            // 
            // lblBaslama
            // 
            this.lblBaslama.AutoSize = true;
            this.lblBaslama.Location = new System.Drawing.Point(6, 196);
            this.lblBaslama.Name = "lblBaslama";
            this.lblBaslama.Size = new System.Drawing.Size(76, 13);
            this.lblBaslama.TabIndex = 6;
            this.lblBaslama.Text = "Başlama Tarihi";
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.Location = new System.Drawing.Point(9, 173);
            this.sayfaSayisi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sayfaSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.Size = new System.Drawing.Size(66, 20);
            this.sayfaSayisi.TabIndex = 5;
            this.sayfaSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(6, 157);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(64, 13);
            this.lblSayfaSayisi.TabIndex = 4;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı";
            // 
            // lblKitapPuani
            // 
            this.lblKitapPuani.AutoSize = true;
            this.lblKitapPuani.Location = new System.Drawing.Point(6, 117);
            this.lblKitapPuani.Name = "lblKitapPuani";
            this.lblKitapPuani.Size = new System.Drawing.Size(61, 13);
            this.lblKitapPuani.TabIndex = 3;
            this.lblKitapPuani.Text = "Kitap Puanı";
            // 
            // cmbPuan
            // 
            this.cmbPuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuan.FormattingEnabled = true;
            this.cmbPuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPuan.Location = new System.Drawing.Point(9, 133);
            this.cmbPuan.Name = "cmbPuan";
            this.cmbPuan.Size = new System.Drawing.Size(69, 21);
            this.cmbPuan.TabIndex = 3;
            // 
            // txtKitapIsmi
            // 
            this.txtKitapIsmi.Location = new System.Drawing.Point(9, 55);
            this.txtKitapIsmi.Name = "txtKitapIsmi";
            this.txtKitapIsmi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapIsmi.TabIndex = 1;
            // 
            // lblKitapIsmi
            // 
            this.lblKitapIsmi.AutoSize = true;
            this.lblKitapIsmi.Location = new System.Drawing.Point(6, 39);
            this.lblKitapIsmi.Name = "lblKitapIsmi";
            this.lblKitapIsmi.Size = new System.Drawing.Size(52, 13);
            this.lblKitapIsmi.TabIndex = 0;
            this.lblKitapIsmi.Text = "Kitap İsmi";
            // 
            // tbpKitapListe
            // 
            this.tbpKitapListe.Controls.Add(this.lbxIstatistik);
            this.tbpKitapListe.Controls.Add(this.dgvKitapListe);
            this.tbpKitapListe.Controls.Add(this.btnDgvListele);
            this.tbpKitapListe.Location = new System.Drawing.Point(4, 22);
            this.tbpKitapListe.Name = "tbpKitapListe";
            this.tbpKitapListe.Padding = new System.Windows.Forms.Padding(3);
            this.tbpKitapListe.Size = new System.Drawing.Size(484, 333);
            this.tbpKitapListe.TabIndex = 1;
            this.tbpKitapListe.Text = "Kitaplar";
            this.tbpKitapListe.UseVisualStyleBackColor = true;
            // 
            // dgvKitapListe
            // 
            this.dgvKitapListe.AllowUserToAddRows = false;
            this.dgvKitapListe.AllowUserToDeleteRows = false;
            this.dgvKitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapListe.Location = new System.Drawing.Point(6, 6);
            this.dgvKitapListe.Name = "dgvKitapListe";
            this.dgvKitapListe.ReadOnly = true;
            this.dgvKitapListe.Size = new System.Drawing.Size(472, 190);
            this.dgvKitapListe.TabIndex = 2;
            // 
            // btnDgvListele
            // 
            this.btnDgvListele.Location = new System.Drawing.Point(6, 202);
            this.btnDgvListele.Name = "btnDgvListele";
            this.btnDgvListele.Size = new System.Drawing.Size(89, 23);
            this.btnDgvListele.TabIndex = 1;
            this.btnDgvListele.Text = "Kitapları Listele";
            this.btnDgvListele.UseVisualStyleBackColor = true;
            this.btnDgvListele.Click += new System.EventHandler(this.btnDgvListele_Click);
            // 
            // lbxIstatistik
            // 
            this.lbxIstatistik.FormattingEnabled = true;
            this.lbxIstatistik.Location = new System.Drawing.Point(290, 202);
            this.lbxIstatistik.Name = "lbxIstatistik";
            this.lbxIstatistik.Size = new System.Drawing.Size(188, 121);
            this.lbxIstatistik.TabIndex = 3;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Mbp_104_Proje.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Proje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpKitapEkleme.ResumeLayout(false);
            this.tbpKitapEkleme.PerformLayout();
            this.pnlKitapSil.ResumeLayout(false);
            this.pnlKitapSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisi)).EndInit();
            this.tbpKitapListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpKitapEkleme;
        private System.Windows.Forms.TextBox txtKitapIsmi;
        private System.Windows.Forms.Label lblKitapIsmi;
        private System.Windows.Forms.TabPage tbpKitapListe;
        private System.Windows.Forms.ComboBox cmbPuan;
        private System.Windows.Forms.Label lblKitapPuani;
        private System.Windows.Forms.NumericUpDown sayfaSayisi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslama;
        private System.Windows.Forms.Label lblBaslama;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.RadioButton rdbTarihleriKaydetme;
        private System.Windows.Forms.RadioButton rdbTarihiKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button btnDgvListele;
        private System.Windows.Forms.DataGridView dgvKitapListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlKitapSil;
        private System.Windows.Forms.CheckBox cbxYazarSil;
        private System.Windows.Forms.Label lblKitapSilYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.TextBox txtKitapSilYazar;
        private System.Windows.Forms.TextBox txtKitapSilIsim;
        private System.Windows.Forms.ListBox lbxIstatistik;
    }
}

