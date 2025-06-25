using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerAccessoriesApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE username = @username AND password_hash = SHA2(@password, 256)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Вхід успішний!", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // або можна передати роль, логін тощо
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
