using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimlikKaydi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Kimlik> k =new List<Kimlik>();
            Kimlik kimlik = new Kimlik();
            kimlik.Ad=tb_ad.Text;
            kimlik.Soyad=tb_soyad.Text;
            kimlik.Tc = tb_tc.Text;
            kimlik.DogumTarihi =tb_dogumtarihi.Text;
            kimlik.DogumYeri=tb_dogumyeri.Text;
            kimlik.Cinsiyet=tb_cinsiyet.Text;
            kimlik.KanGrubu=tb_kangrubu.Text;
            k.Add(kimlik);
            lbl_liste.Text += $"{k[0].Ad } {k[0].Soyad    }{k[0].Tc} {k[0].DogumTarihi} {k[0].DogumYeri} {k[0].Cinsiyet} {k[0].KanGrubu}\n"; 
        }
    }
}
