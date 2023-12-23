using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Percobaan2.Controller;

using System.Data.SQLite;
using Percobaan2.Model.Entity;

namespace Percobaan2.View
{
    public partial class MainMenu : Form
    {
        private PelangganController controller;
        private List<AkunPelanggan> listOfAkunPelanggan = new List<AkunPelanggan>();
        public MainMenu()
        {

            controller = new PelangganController();
            InitializeComponent();
            InisialisasiListView();
            cmbCariTransaksi.SelectedIndex = 0;
        }

        private void lvwAkun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InisialisasiListView()
        {
            lvwAkun.View = System.Windows.Forms.View.Details;
            lvwAkun.FullRowSelect = true;
            lvwAkun.GridLines = true;
            lvwAkun.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Username", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Nama", 170, HorizontalAlignment.Left);
            lvwAkun.Columns.Add("email", 80, HorizontalAlignment.Center);

            lvwTransaksi.View = System.Windows.Forms.View.Details;
            lvwTransaksi.FullRowSelect = true;
            lvwTransaksi.GridLines = true;
            lvwTransaksi.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Username", 91, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Tanggal", 170, HorizontalAlignment.Left);
            lvwTransaksi.Columns.Add("Waktu", 80, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Waktu Terpakai", 80, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Staff", 80, HorizontalAlignment.Center);


        }

        private void LoadDataMutasi()
        {
             lvwTransaksi.Items.Clear();

            // ekstrak objek mhs dari collection
            foreach (var akunPelanggan in listOfAkunPelanggan)
            {
                   var noUrut = lvwTransaksi.Items.Count + 1;

                  var item = new ListViewItem(noUrut.ToString());
                   item.SubItems.Add(akunPelanggan.Username);
                //  item.SubItems.Add(akunPelanggan.tanggal.ToString());

                //    item.SubItems.Add(mutasi.nama_barang);
                //   item.SubItems.Add(mutasi.jumlah.ToString());
                //   item.SubItems.Add(mutasi.nominal.ToString());
                //  item.SubItems.Add(mutasi.keterangan);
                // tampilkan data mhs ke listview
                //  lvwTransaksi.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lstTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCariTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void cmbCariTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
