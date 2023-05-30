namespace Library_EXAM.Forms
{
    partial class EditBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cmbPolka = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.libraryDBDataSet = new Library_EXAM.LibraryDBDataSet();
            this.polkaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polkaTableTableAdapter = new Library_EXAM.LibraryDBDataSetTableAdapters.PolkaTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polkaTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Где хранится";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(105, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Информация о книге";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 73);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(164, 115);
            this.txtAuthor.MaxLength = 50;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(207, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // cmbPolka
            // 
            this.cmbPolka.DataSource = this.polkaTableBindingSource;
            this.cmbPolka.DisplayMember = "Description";
            this.cmbPolka.FormattingEnabled = true;
            this.cmbPolka.Location = new System.Drawing.Point(164, 161);
            this.cmbPolka.Name = "cmbPolka";
            this.cmbPolka.Size = new System.Drawing.Size(207, 21);
            this.cmbPolka.TabIndex = 6;
            this.cmbPolka.ValueMember = "Id";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(179, 244);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Добавить";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polkaTableBindingSource
            // 
            this.polkaTableBindingSource.DataMember = "PolkaTable";
            this.polkaTableBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // polkaTableTableAdapter
            // 
            this.polkaTableTableAdapter.ClearBeforeFill = true;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.cmbPolka);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о книге";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polkaTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cmbPolka;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource polkaTableBindingSource;
        private LibraryDBDataSetTableAdapters.PolkaTableTableAdapter polkaTableTableAdapter;
    }
}