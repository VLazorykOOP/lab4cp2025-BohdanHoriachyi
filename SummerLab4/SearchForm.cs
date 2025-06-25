using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerAccessoriesApp
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            comboBoxSearchType.Items.AddRange(new string[] { "Graphic Adapter", "CD Device", "Hard Drive" });
            comboBoxSearchType.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedType = comboBoxSearchType.SelectedItem?.ToString() ?? "";
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("Виберіть тип пристрою.");
                return;
            }

            string table = "";
            switch (selectedType)
            {
                case "Graphic Adapter":
                    table = "GraphicAdapters";
                    break;
                case "CD Device":
                    table = "CDDevices";
                    break;
                case "Hard Drive":
                    table = "HardDrives";
                    break;
            }

            string query = $"SELECT * FROM {table} WHERE manufacturer LIKE @text OR type LIKE @text";

            using (var conn = Database.GetConnection())
            {
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@text", "%" + searchText + "%");

                var adapter = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewResults.DataSource = dt;
            }
        }
    }
}
