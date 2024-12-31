using Microsoft.EntityFrameworkCore;
using MiniOgrenciBilgiSistemi.models;

namespace MiniOgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        Ogrenci ogrenci;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ogrEkle_Click(object sender, EventArgs e)
        {

            using (var ctx = new OgrenciYonetimDbContext())
            {
                //ctx.Siniflar.Where()
            }

            ogrenci.Ad = txtBox_ogrAd.Text.Trim();
            ogrenci.Soyad = txtBox_ogrSoyad.Text.Trim();
            ogrenci.Numara = txtBox_ogrNumara.Text.Trim();
            ogrenci.SinifId = 1;
            using (var ctx = new OgrenciYonetimDbContext())
            {
                ctx.Ogrenciler.Add(ogrenci);
                ctx.SaveChanges();
            }
        }

        private void btn_ogrGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_ogrBul_Click(object sender, EventArgs e)
        {
            string ogrNumara = txtBox_ogrNumara.Text.Trim();

            using (var ctx = new OgrenciYonetimDbContext())
            {
                //List<Sinif> Siniflar = SiniflariGetir();

                List<Ogrenci> eslesenOgrenciler;
                eslesenOgrenciler = ctx.Ogrenciler.Where(o => o.Numara == ogrNumara).ToList();
                txtBox_ogrAd.Text = eslesenOgrenciler[0].Ad.ToString();
                txtBox_ogrSoyad.Text = eslesenOgrenciler[0].Soyad.ToString();
                txtBox_ogrNumara.Text = eslesenOgrenciler[0].Numara.ToString();
                cmbBox_ogrSinif.Items.Add(eslesenOgrenciler[0].Sinif.SinifAd);
            }
        }

        static List<Sinif> SiniflariGetir()
        {
            List<Sinif> Siniflar;
            
            using(var ctx = new OgrenciYonetimDbContext())
            {
                Siniflar = ctx.Siniflar.ToList();
            }

            return Siniflar;
        }
    }
}
