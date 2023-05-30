using System;
using System.Windows.Forms;

namespace Library_EXAM.Forms
{
    public partial class PolkiForm : Form
    {
        public PolkiForm()
        {
            InitializeComponent();
        }

        private void PolkiForm_Load(object sender, EventArgs e)
        {
            this.polkaTableTableAdapter.Fill(this.libraryDBDataSet.PolkaTable);
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.polkaTableTableAdapter.Update(this.libraryDBDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление записи", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
