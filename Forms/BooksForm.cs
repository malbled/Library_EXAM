using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Library_EXAM.Forms
{
    public partial class BooksForm : Form
    {
        string SqlConnectionString = @"Data Source=LEKSA\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";
        SqlConnection con;
        bool dop;
        public BooksForm()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadPrint();
        }
        public void LoadPrint()
        {
            try
            {
                con = new SqlConnection(SqlConnectionString);
                con.Open();
                string query = "SELECT [BooksTable].[Id],[BooksTable].[Name],[BooksTable].[Author],[PolkaTable].[Description] " +
                    "FROM [BooksTable],[PolkaTable] WHERE [BooksTable].[Polka] = [PolkaTable].[Id]";
                var comand = new SqlCommand(query);
                comand.Connection = con;
                var reader = comand.ExecuteReader();
                List<string[]> data = new List<string[]>();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Данные отсутсвуют", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    while (reader.Read())
                    {
                        data.Add(new string[4]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                    }
                    foreach (string[] s in data)
                        dgvBooks.Rows.Add(s);
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
        private DataGridViewColumn COL;
        private void btnSort_Click(object sender, EventArgs e)
        {
            COL = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0: COL = Column2; break;
                case 1: COL = Column3; break;
                case 2: COL = Column4; break;
            }
            if (radioButton1.Checked)
            {
                dgvBooks.Sort(COL, ListSortDirection.Ascending);
            }
            else
            {
                dgvBooks.Sort(COL, ListSortDirection.Descending);
            }
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            if(txtFiltr.Text.Length > 0)
            {
                for (int i = 0; i < dgvBooks.Rows.Count; i++)
                {
                    dgvBooks.Rows[i].Visible = false;
                    for (int c = 0; c < dgvBooks.Columns.Count; c++)
                    {
                        if (dgvBooks[c, i].Value.ToString() == txtFiltr.Text)
                        {
                            dgvBooks.Rows[i].Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите критерий для фильтрации", "Сообщение");
            }   
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvBooks.Rows.Clear();
            LoadPrint();
            txtFiltr.Text = "";
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            if(txtPoisk.Text.Length > 0)
            {
                dgvBooks.ClearSelection();
                dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                for (int i = 0; i <= dgvBooks.Rows.Count - 1; i++)
                    for (int j = 0; j <= dgvBooks.ColumnCount - 1; j++)
                        if (dgvBooks.Rows[i].Cells[j].Value != null && dgvBooks.Rows[i].Cells[j].Value.ToString() == txtPoisk.Text)
                            dgvBooks.Rows[i].Cells[j].Selected = true;
            }
            else
            {
                MessageBox.Show("Введите название книги для поиска", "Сообщение");
            } 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;
            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;
            xlSheet = (Excel.Worksheet)wBook.Sheets[1];
            xlSheet.Name = "Домашняя библиотека";
            xlApp.Cells[1, 1] = "Код книги";
            xlApp.Cells[1, 2] = "Название";
            xlApp.Cells[1, 3] = "Автор";
            xlApp.Cells[1, 4] = "Место хранения";
            for (int i = 0; i < dgvBooks.Rows.Count; i++)
            {
                for (int j = 0; j < dgvBooks.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dgvBooks.Rows[i].Cells[j].Value.ToString();
                    xlSheet.Cells.HorizontalAlignment = 1;
                    xlApp.Visible = true;
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["Column1"].Value);
            DialogResult dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string guery = $"DELETE BooksTable WHERE Id = {id}";
                con = new SqlConnection(SqlConnectionString);
                con.Open();
                SqlCommand command = new SqlCommand(guery, con);
                command.ExecuteNonQuery();
                con.Close();
                dgvBooks.Rows.Clear();
                LoadPrint();
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = editbtn.Enabled = dgvBooks.SelectedRows.Count > 0;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            dop = true;
            EditBookForm editBookForm = new EditBookForm(dop,1);
            editBookForm.ShowDialog(this);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int index = dgvBooks.CurrentCell.RowIndex;
            dop = false;
            var id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["Column1"].Value);
            EditBookForm editBookForm = new EditBookForm(dop,id);
            editBookForm.ShowDialog(this);
        }
    }
}
