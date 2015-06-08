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
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (this.LoginForm.Text.Length == 0)
                MessageBox.Show("Логин не введен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.PasswordBox.Text.CompareTo(this.ConfirmBox.Text) != 0)
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.EmailBox.Text.Length == 0)
                MessageBox.Show("E-mail не введен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlConnection conn =  new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse");
                SqlCommand cmd = new SqlCommand("INSERT INTO [UserInfo] ([UserLogin], [UserPassword], [UserEmail]) VALUES (@log, @pass, @email)", conn);
                cmd.Parameters.AddWithValue("@log", LoginForm.Text);
                cmd.Parameters.AddWithValue("@pass", PasswordBox.Text);
                cmd.Parameters.AddWithValue("@email", EmailBox.Text);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Регистрация прошла успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch( SqlException  )
                {
                    MessageBox.Show("Ошибка при регистрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.PasswordBox.Clear();
            this.ConfirmBox.Clear();
        }
    }
}
