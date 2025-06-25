using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerAccessoriesApp
{
    public partial class DeviceForm : Form
    {
        public DeviceForm()
        {
            InitializeComponent();
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            comboBoxDeviceType.Items.AddRange(new string[] { "Graphic Adapter", "CD Device", "Hard Drive" });
            comboBoxDeviceType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Перевірка: чи вибрано тип пристрою
            if (comboBoxDeviceType.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть тип пристрою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримання значень
            string selectedType = comboBoxDeviceType.SelectedItem.ToString()!;
            string deviceType = txtType.Text.Trim();
            string manufacturer = txtManufacturer.Text.Trim();
            int value = (int)numericValue.Value;

            // Перевірка на заповнення
            if (string.IsNullOrEmpty(deviceType) || string.IsNullOrEmpty(manufacturer))
            {
                MessageBox.Show("Усі текстові поля мають бути заповнені.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевірка на значення параметра
            if (value <= 0)
            {
                MessageBox.Show("Значення параметра повинно бути більше за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            switch (selectedType)
            {
                case "Graphic Adapter":
                    query = "INSERT INTO GraphicAdapters (type, manufacturer, memory_gb) VALUES (@type, @manufacturer, @value)";
                    break;
                case "CD Device":
                    query = "INSERT INTO CDDevices (type, manufacturer, frequency_mhz) VALUES (@type, @manufacturer, @value)";
                    break;
                case "Hard Drive":
                    query = "INSERT INTO HardDrives (type, manufacturer, capacity_gb) VALUES (@type, @manufacturer, @value)";
                    break;
                default:
                    MessageBox.Show("Невідомий тип пристрою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Додавання до бази
            try
            {
                using (var conn = Database.GetConnection())
                {
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", deviceType);
                    cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Пристрій успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка бази даних:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
