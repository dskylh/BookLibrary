using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace Mbp_104_Proje
{
    public partial class Form1 : Form
    {
        List<Kitap> kitaplar = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKitapIsmi.Text != "" && txtYazar.Text != "" && cmbPuan.Text != "")
            {
                Kitap kitap = new Kitap();
                kitap.isim = txtKitapIsmi.Text;
                kitap.yazar = txtYazar.Text;
                kitap.puan = Convert.ToInt32(cmbPuan.Text);
                kitap.sayfaSayisi = (int)sayfaSayisi.Value;
                if (rdbTarihiKaydet.Checked)
                {
                    kitap.baslamaTarihi = dtpBaslama.Text;
                    kitap.bitirmeTarihi = dtpBitis.Text;
                }
                kitaplar.Add(kitap);
                dgvKitapListe.DataSource = new BindingSource() { DataSource = kitaplar };

            }
            else
            {
                MessageBox.Show("lutfen gerekli alanlari doldurunuz.");
            }
        }

        private void btnDgvListele_Click(object sender, EventArgs e)
        {

            dgvKitapListe.DataSource = new BindingSource() { DataSource = kitaplar };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKitapListe.DataSource = new BindingSource() { DataSource = kitaplar };
        }


        private void cbxYazarSil_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxYazarSil.Checked)
            {
                lblKitapSilYazar.Enabled = true;
                txtKitapSilYazar.Enabled = true;
            }
            else
            {
                lblKitapSilYazar.Enabled = false;
                txtKitapSilYazar.Enabled = false;
                if (txtKitapSilYazar.Text != "")
                {
                    txtKitapSilYazar.Text = "";
                }
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            bool kitapSilindi = false;
            if (txtKitapSilIsim.Text != "")
            {
                foreach (var item in kitaplar)
                {
                    if (item.isim == txtKitapSilIsim.Text)
                    {

                        kitaplar.Remove(item);
                        dgvKitapListe.DataSource = new BindingSource() { DataSource = kitaplar };
                        kitapSilindi = true;
                        break;
                    }
                }
            }
            else if (txtKitapSilYazar.Text != "")
            {
                kitaplar.RemoveAll(x => x.yazar == txtKitapSilYazar.Text);

                dgvKitapListe.DataSource = new BindingSource() { DataSource = kitaplar };
                kitapSilindi = true;
            }
            if (!kitapSilindi)
            {
                MessageBox.Show("Kitap Bulunamadı.");
            }
        }
       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxIstatistik.Items.Clear();
            string kitapSayisi = kitaplar.Count.ToString();
            string kitapSayfaSayisi = Program.sayfaSayisi(kitaplar);
            string ortalamPuan = Program.ortalamaPuan(kitaplar);
            lbxIstatistik.Items.Add($"Okunan Kitap Sayısı: {kitapSayisi}");
            lbxIstatistik.Items.Add($"Okunan Sayfa Sayısı: {kitapSayfaSayisi}");
            lbxIstatistik.Items.Add($"Verilen Ortalama Puan: {ortalamPuan}");
        }
    }
}