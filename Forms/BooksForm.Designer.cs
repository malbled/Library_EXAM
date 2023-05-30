namespace Library_EXAM.Forms
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.editbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtPoisk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbtn,
            this.editbtn,
            this.toolStripSeparator1,
            this.deletebtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1209, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addbtn
            // 
            this.addbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(63, 22);
            this.addbtn.Text = "Добавить";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deletebtn.Enabled = false;
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(55, 22);
            this.deletebtn.Text = "Удалить";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editbtn.Enabled = false;
            this.editbtn.Image = ((System.Drawing.Image)(resources.GetObject("editbtn.Image")));
            this.editbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(91, 22);
            this.editbtn.Text = "Редактировать";
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBooks.Location = new System.Drawing.Point(12, 28);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(943, 422);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название книги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Автор";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Полка, где хранится";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(961, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Столбец для сортировки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Название",
            "Автор",
            "Полка"});
            this.listBox1.Location = new System.Drawing.Point(6, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 69);
            this.listBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "по убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(6, 149);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(107, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(967, 252);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(220, 20);
            this.txtFiltr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Критерий для фильтрации";
            // 
            // btnFiltr
            // 
            this.btnFiltr.Location = new System.Drawing.Point(967, 278);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(107, 23);
            this.btnFiltr.TabIndex = 4;
            this.btnFiltr.Text = "Фильтровать";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1080, 278);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(107, 23);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Показать всё";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtPoisk
            // 
            this.txtPoisk.Location = new System.Drawing.Point(967, 329);
            this.txtPoisk.Name = "txtPoisk";
            this.txtPoisk.Size = new System.Drawing.Size(220, 20);
            this.txtPoisk.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(967, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск по названию книги";
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(967, 355);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(107, 23);
            this.btnPoisk.TabIndex = 8;
            this.btnPoisk.Text = "Найти";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(967, 427);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(230, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Экспорт в Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 469);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoisk);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о книгах в доме";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripButton editbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtPoisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.DataGridView dgvBooks;
    }
}