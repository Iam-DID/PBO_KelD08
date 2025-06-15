using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_KelD08.JAPRI.Controller;
using PBO_KelD08.JAPRI.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBO_KelD08.JAPRI.View
{
    public partial class V_Ganti_Jadwal : Form
    {
        C_Ganti_Jadwal Controller;
        public V_Ganti_Jadwal(C_Ganti_Jadwal controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.SwitchToProfile();
        }

        private void infokelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoKelas();
        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            Controller.SwitchToInfoJadwal();
        }

        private void ruangkelas_Click(object sender, EventArgs e)
        {
            Controller.SwitchToRuangKelas();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void V_Ganti_Jadwal_Load(object sender, EventArgs e)
        {
            // Isi combobox ruangan
            List<Data_Ruangan> ruanganList = Controller.GetlistRuangan();
            ruangan.DataSource = null;
            ruangan.DataSource = ruanganList;
            ruangan.DisplayMember = "nama_ruangan";
            ruangan.ValueMember = "id_ruangan";

            // Panggil langsung refreshform agar isi tabel & tombol sesuai
            refreshform();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.setpilihan();
        }

        private void ruangan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jammulai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jammulai.SelectedItem != null)
            {
                jamselesai.Items.Clear();
                jamselesai.SelectedIndex = -1;
                jamselesai.Text = "";
                string jamMulaiDipilih = jammulai.SelectedItem.ToString();
                //jamselesai.Text = Controller.HitungJamSelesai(jamMulaiDipilih);
                jamselesai.Items.Add((Controller.HitungJamSelesai(jamMulaiDipilih)).ToString());
            }
        }

        private void jamselesai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ubah_Click(object sender, EventArgs e)
        {
            Controller.simpanjadwal();
            refreshform();
        }

        private void refreshform()
        {
            List<Data_PilihanJadwal> list = Controller.listjadwal();

            // Siapkan data binding dengan kolom tambahan (No)
            var data = list.Select((d, i) => new
            {
                ID = d.id_pilihan,
                No = i + 1,
                Tanggal = d.tanggal.ToString("yyyy-MM-dd"),
                JamMulai = d.jam_mulai.ToString(@"hh\:mm"),
                JamSelesai = d.jam_selesai.ToString(@"hh\:mm"),
                Ruangan = d.nama_ruangan,
                NoteValue = d.note // alias kolom untuk digunakan internal
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["ID"].Visible = false;

            // Hapus tombol sebelumnya jika ada
            if (dataGridView1.Columns.Contains("Hapus"))
                dataGridView1.Columns.Remove("Hapus");

            if (dataGridView1.Columns.Contains("Note"))
                dataGridView1.Columns.Remove("Note");

            // Sembunyikan kolom NoteValue agar tidak ditampilkan tapi bisa diakses
            if (dataGridView1.Columns.Contains("NoteValue"))
                dataGridView1.Columns["NoteValue"].Visible = false;

            // Tambah tombol Hapus
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Hapus";
            deleteButton.HeaderText = "Hapus";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButton);

            // Tambah tombol Note
            DataGridViewButtonColumn noteButton = new DataGridViewButtonColumn();
            noteButton.Name = "Note";
            noteButton.HeaderText = "Note";
            noteButton.Text = "Lihat";
            noteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(noteButton);

            // Reset pilihan form (opsional)
            jammulai.SelectedIndex = -1;
            jamselesai.Items.Clear();
            jamselesai.Text = "";
            jamselesai.SelectedIndex = -1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Hapus")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult confirm = MessageBox.Show("Yakin ingin menghapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        Controller.deletejadwal(id);
                        MessageBox.Show("Jadwal berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshform();
                    }
                }

                else if (columnName == "Note")
                {
                    string note = dataGridView1.Rows[e.RowIndex].Cells["NoteValue"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(note))
                    {
                        MessageBox.Show("Belum ada catatan untuk jadwal ini.", "Catatan Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(note, "Catatan Jadwal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

