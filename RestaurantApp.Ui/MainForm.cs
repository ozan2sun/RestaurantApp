using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestaurantApp.Data;

namespace RestaurantApp.Ui
{
    public partial class MainForm : Form
    {
        KafeVeri db = new KafeVeri();
        public MainForm()
        {
            VerileriYukle();
            InitializeComponent();
            MasalariYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("data.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {
                OrnekUrunleriYukle();
            }
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Hamburger", BirimFiyat = 110.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 25.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Pizza", BirimFiyat = 140.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Kajun", BirimFiyat = 89.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Sufle", BirimFiyat = 40.00m });
        }

        private void MasalariYukle()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                var lvi = new ListViewItem($"Masa {i}");
                lvi.ImageKey = db.MasaDoluMu(i)? "dolu" : "bos";
                lvi.Tag = i; //list view item üzerinde daha sonra erişebilmek için masa noyu saklıyoruz 
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            //Seçilen masa numarasını yakaladık(Seçilen itemin ilki)
            var lvi = lvwMasalar.SelectedItems[0];
            int masaNo = (int)lvi.Tag;
            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            //Sipariş varsa olanı buldurduk. Yoksa yeniden oluşturduk
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }
            var sf = new SiparisForm(db, siparis);
            sf.MasaTasindi += Sf_MasaTasindi;
            DialogResult dr = sf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lvi.ImageKey = "bos";
                lvi.Selected = false;
            }
        }

        private void Sf_MasaTasindi(object sender, MasaTasindiEventArgs e)
        {
            foreach (ListViewItem lvi in lvwMasalar.Items)
            {
                int masaNo = (int)lvi.Tag;

                if (masaNo == e.EskiMasaNo)
                {
                    lvi.ImageKey = "bos";
                    lvi.Selected = false;
                }
                else if (masaNo == e.YeniMasaNo)
                {
                    lvi.ImageKey = "dolu";
                    lvi.Selected = true;
                }
            }
        }
        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("data.json", json);
        }
    }
}
