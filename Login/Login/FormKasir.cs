using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            cmbMakanan.Items.Add("Paket Ayam Goreng");
            cmbMakanan.Items.Add("Paket Lele Goreng");
            cmbMakanan.Items.Add("Paket Ikan Bakar");
            cmbMakanan.Items.Add("Paket Ayam Geprek");
            cmbMinuman.Items.Add("Es Teh");
            cmbMinuman.Items.Add("Jeruk Panas");
            cmbMinuman.Items.Add(" Es Jeruk ");
            cmbMinuman.Items.Add("Teh Anget");
        }

        private void cmbMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;

            pilih = cmbMakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtHargaMakanan.Text = "10000";
                    Total();
                    break;
                case 1:
                    txtHargaMakanan.Text = "10000";
                    Total();
                    break;
                case 2:
                    txtHargaMakanan.Text = "30000";
                    Total();
                    break;
                case 3:
                    txtHargaMakanan.Text = "15000";
                    Total();
                    break;
            }
        }

        private void cmbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;

            pilih = cmbMinuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtHargaMinuman.Text = "3000";
                    Total();
                    break;
                case 1:
                    txtHargaMinuman.Text = "5000";
                    Total();
                    break;
                case 2:
                    txtHargaMinuman.Text = "5000";
                    Total();
                    break;
                case 3:
                    txtHargaMinuman.Text = "3000";
                    Total();
                    break;
            }
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            if (txtBayar.Text == "" || txtBayar.Text == " ")
            {
                txtBayar.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtBayar.Text);
                int b = Convert.ToInt32(txtTotal.Text);
                int kembali = 0;
                kembali = a - b;
                txtKembali.Text = Convert.ToString(kembali);
            }
        }
        private void txtBayar_TextChanged(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("====================" +
               "\n\tWarung Makan Ira" +
               "\n\tKasir: " + txtNamaKasir.Text +
               "\n====================" +
               "\nPesan: " +
               "\n" + cmbMakanan.Text + "\tRp. " + txtSubTotalMakanan.Text +
               "\n" + cmbMinuman.Text + "\tRp. " + txtSubTotalMinuman.Text +
               "\n====================" +
               "\nTotal\t\t: Rp. " + txtTotal.Text +
               "\nBayar\t\t: Rp. " + txtBayar.Text +
               "\nKembali\t\t: Rp." + txtKembali.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int jumlah, hrgMakan;
            int subtotal = 0;
            hrgMakan = Convert.ToInt32(txtHargaMakanan.Text);
            jumlah = (int)numericUpDown1.Value;
            subtotal = hrgMakan * jumlah;
            txtSubTotalMakanan.Text = subtotal.ToString();
            Total();
        }
        public void Total()
        {
            if (int.TryParse(txtSubTotalMakanan.Text, out int hrgMakan) && int.TryParse(txtSubTotalMinuman.Text, out int hrgMinum))
            {
                int total = hrgMakan + hrgMinum;
                txtTotal.Text = total.ToString();
            }
            else
            {
               
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int jumlah, hrgMinum;
            int subtotal = 0;
            hrgMinum = Convert.ToInt32(txtHargaMinuman.Text);
            jumlah = (int)numericUpDown2.Value;
            subtotal = hrgMinum * jumlah;
            txtSubTotalMinuman.Text = subtotal.ToString();
            Total();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMakanan.Text = "";
            cmbMinuman.Text = "";
            txtHargaMakanan.Text = "0";
            txtHargaMinuman.Text = "0";
            txtTotal.Text = "0";
            txtBayar.Text = "0";
            txtKembali.Text = "0";
            txtSubTotalMakanan.Text = "0";
            txtSubTotalMinuman.Text = "0";
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            txtNamaKasir.Clear();
        }

        private void txtKembali_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
