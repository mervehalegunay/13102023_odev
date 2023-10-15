using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _13102023_odev
{
    public partial class Form1 : Form
    {
        RandevuModel model;

        public Form1()
        {
            InitializeComponent();               
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            model = new RandevuModel()
            {
                TcKn = txtTC.Text,
                AdSoyad = txtAdSoyad.Text,
                Telefon = mtxtTelefon.Text,
                Cinsiyet = rbErkek.Checked ? "Erkek" : "Kadýn",
                Poliklinik = cbPoliklinik.SelectedItem.ToString(),
                Tarih = dtTarih.Value.ToShortDateString(),
                Saat = rbSaat12.Checked ? "12:00" :
                       rbSaat13.Checked ? "13:00" :
                       rbSaat14.Checked ? "14:00" :
                       "15:00"
            };
            
            DialogResult dialogResult = MessageBox.Show("Gerçekten kaydetmek istiyor musunuz?", "Mesaj", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                lbRandevular.Items.Add(model.AdSoyad + "-" + model.Poliklinik + "-" + model.Tarih + "-" + model.Saat);
                MessageBox.Show("Kaydedildi", "", MessageBoxButtons.OK);
            }
        }

        private void lbRandevular_DoubleClick(object sender, EventArgs e)
        {
            string mesaj = "Ad Soyad : " + model.AdSoyad + "\n" +
                           "TC : " + model.TcKn + "\n" +
                           "Cinsiyet : " + model.Cinsiyet;
            MessageBox.Show(mesaj, "", MessageBoxButtons.OK);
            Clear();
        }

        private void Clear()
        {
            txtTC.Text = "";
            txtAdSoyad.Text = "";
            mtxtTelefon.Text = "";
            rbErkek.Checked = false;
            rbKadin.Checked = false;
            cbPoliklinik.Text = "";
            dtTarih.Text = "";
            rbSaat12.Checked = false;
            rbSaat13.Checked = false;
            rbSaat14.Checked = false;
            rbSaat15.Checked = false;
        }
    }
}