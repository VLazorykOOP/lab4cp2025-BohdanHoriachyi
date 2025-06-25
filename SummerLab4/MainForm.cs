using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerAccessoriesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadAdapters()
        {
            using (var conn = Database.GetConnection())
            {
                string query = "SELECT * FROM GraphicAdapters";
                var adapter = new MySqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void LoadCDDevices()
        {
            using (var conn = Database.GetConnection())
            {
                string query = "SELECT * FROM CDDevices";
                var adapter = new MySqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void LoadHardDrives()
        {
            using (var conn = Database.GetConnection())
            {
                string query = "SELECT * FROM HardDrives";
                var adapter = new MySqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        // Події меню
        private void графічніАдаптериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAdapters();
        }

        private void cDПристроїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCDDevices();
        }

        private void вінчестериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadHardDrives();
        }

        private void авторизаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // за замовчуванням завантажуємо граф. адаптери
            LoadAdapters();
        }
    }
}
