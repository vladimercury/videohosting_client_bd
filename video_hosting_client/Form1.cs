using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace video_hosting_client
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginForm.Text.Length == 0)
                MessageBox.Show("Логин не введен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Cursor = Cursors.WaitCursor;
                using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
                {

                    SqlCommand cmd = new SqlCommand("SELECT UserId FROM [UserInfo] WHERE UserLogin = @log AND UserPassword = @pass", connection);
                    cmd.Parameters.AddWithValue("@log", LoginForm.Text);
                    cmd.Parameters.AddWithValue("@pass", PasswordBox.Text);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            IDataRecord record = (IDataRecord)reader;
                            new MainBrowser(record["UserId"].ToString(), this.LoginForm.Text, this).Show();
                            this.Visible = false;
                        }
                        else
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }
                    catch
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Нет доступа к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoHostingDataSet.UserInfo". При необходимости она может быть перемещена или удалена.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new RegistrationForm().ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MainBrowser("", "", this).Show();
            this.Visible = false;
        }
    }
}
