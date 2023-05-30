using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_EXAM.Forms
{
    public partial class AuthorizationForm : Form
    { 
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != string.Empty && txtPass.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=LEKSA\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True");
                con.Open();
                var command = new SqlCommand("select * from AuthoTable where Login='" + txtLogin.Text + "' and Password='" + txtPass.Text + "'", con);
                var dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
