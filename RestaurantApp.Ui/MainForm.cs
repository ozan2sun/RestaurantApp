using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantApp.Data;

namespace RestaurantApp.Ui
{
    public partial class MainForm : Form
    {
        KafeVeri db = new KafeVeri();
        public MainForm()
        {
            InitializeComponent();
            MasalariYukle();
            OrnekUrunleriYukle();
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
                lvi.ImageKey = "bos";
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
            DialogResult dr=new SiparisForm(db, siparis).ShowDialog();
            if (dr == DialogResult.OK)
            {
                lvi.ImageKey = "bos";
                lvi.Selected = false;
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
    }
}
