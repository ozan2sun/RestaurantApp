using RestaurantApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Ui
{
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        BindingList<Urun> _blUrunler;
        Urun _duzenlenen;

        public UrunlerForm(KafeVeri db)
        {
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false;
            _db = db;
            dgvUrunler.DataSource = _db.Urunler;
            _blUrunler = new BindingList<Urun>(_db.Urunler);
            dgvUrunler.DataSource = _blUrunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtUrunAd.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Ürün adı girmediniz");
                return;
            }
            if (_duzenlenen == null)
            {
            _blUrunler.Add(new Urun
            {
                UrunAd = ad,
                BirimFiyat = nudBirimFiyat.Value
            });
            }
            else
            {
                _duzenlenen.UrunAd = ad;
                _duzenlenen.BirimFiyat=nudBirimFiyat.Value;
            }
            Sifirla();
        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var satir = dgvUrunler.Rows[e.RowIndex];
            _duzenlenen = (Urun)satir.DataBoundItem;
            btnEkle.Text = "KAYDET";
            txtUrunAd.Text=_duzenlenen.UrunAd.ToString();
            nudBirimFiyat.Value = _duzenlenen.BirimFiyat;
            dgvUrunler.Enabled = true;
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Sifirla();
        }

        private void Sifirla()
        {
            _duzenlenen = null;
            btnEkle.Text = "EKLE";
            txtUrunAd.Clear();
            nudBirimFiyat.Value = 0;
            dgvUrunler.Enabled = true;
            btnIptal.Hide();
            txtUrunAd.Focus();
        }

        private void dgvUrunler_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçili Ürün Silinecek", "Onaylıyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            e.Cancel = dr == DialogResult.No;
        }
    }
}
