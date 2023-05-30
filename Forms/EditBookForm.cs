using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_EXAM.Forms
{
    public partial class EditBookForm : Form
    {
        string SqlConnectionString = @"Data Source=LEKSA\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";
        SqlConnection con;
        int idd;
        public EditBookForm(bool dopa, int id)
        {
            InitializeComponent();
            bool DOPA = dopa;
            idd = id;
            if(DOPA == true)
            {
                btnAddBook.Visible = true;
                btnSave.Visible = false;
            }
            else
            {
                btnSave.Visible = true;
                btnAddBook.Visible = false;
                try
                {
                    con = new SqlConnection(SqlConnectionString);
                    con.Open();
                    var query = $"SELECT [BooksTable].[Id],[BooksTable].[Name],[BooksTable].[Author],[BooksTable].[Polka] " +
                        $"FROM [BooksTable],[PolkaTable] WHERE [BooksTable].[Id] = {idd}";
                    var comand = new SqlCommand(query);
                    comand.Connection = con;
                    var reader = comand.ExecuteReader();
                    if (reader.HasRows == false)
                    {
                        MessageBox.Show("Данные отсутсвуют", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            txtName.Text = reader[1].ToString();
                            txtAuthor.Text = reader[2].ToString();
                            cmbPolka.SelectedValue = Convert.ToInt32(reader[3]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtAuthor.Text.Length > 0 && txtName.Text.Length > 0)
            {
                string qwery = $"INSERT BooksTable VALUES ({cmbPolka.SelectedValue},'{txtName.Text}','{txtAuthor.Text}')";
                con = new SqlConnection(SqlConnectionString);
                con.Open();
                SqlCommand command = new SqlCommand(qwery, con);
                command.ExecuteNonQuery();
                con.Close();
                BooksForm main = this.Owner as BooksForm;
                main.dgvBooks.Rows.Clear();
                main.LoadPrint();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите все данные", "Сообщение");
            }   
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            this.polkaTableTableAdapter.Fill(this.libraryDBDataSet.PolkaTable);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text.Length > 0 && txtName.Text.Length > 0)
            {
                var qwery = $"UPDATE BooksTable SET Name = '{txtName.Text}',Author = '{txtAuthor.Text}',Polka = {cmbPolka.SelectedValue} WHERE Id = {idd}";
                con = new SqlConnection(SqlConnectionString);
                con.Open();
                SqlCommand command = new SqlCommand(qwery, con);
                command.ExecuteNonQuery();
                con.Close();
                BooksForm main = this.Owner as BooksForm;
                main.dgvBooks.Rows.Clear();
                main.LoadPrint();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите все данные", "Сообщение");
            }
        }
    }
}
