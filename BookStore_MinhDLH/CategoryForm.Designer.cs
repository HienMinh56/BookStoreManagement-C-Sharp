namespace BookStore_MinhDLH
{
    partial class CategoryForm
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
            gbCatgoryInfo = new GroupBox();
            txtDescription = new TextBox();
            txtBookGenreType = new TextBox();
            txtId = new TextBox();
            lblDesc = new Label();
            lblBookGenreType = new Label();
            lblId = new Label();
            dgvCateList = new DataGridView();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            gbCatgoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCateList).BeginInit();
            gbSearch.SuspendLayout();
            gbTask.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gbCatgoryInfo
            // 
            gbCatgoryInfo.Controls.Add(txtDescription);
            gbCatgoryInfo.Controls.Add(txtBookGenreType);
            gbCatgoryInfo.Controls.Add(txtId);
            gbCatgoryInfo.Controls.Add(lblDesc);
            gbCatgoryInfo.Controls.Add(lblBookGenreType);
            gbCatgoryInfo.Controls.Add(lblId);
            gbCatgoryInfo.ForeColor = Color.Black;
            gbCatgoryInfo.Location = new Point(12, 11);
            gbCatgoryInfo.Margin = new Padding(3, 2, 3, 2);
            gbCatgoryInfo.Name = "gbCatgoryInfo";
            gbCatgoryInfo.Padding = new Padding(3, 2, 3, 2);
            gbCatgoryInfo.Size = new Size(387, 293);
            gbCatgoryInfo.TabIndex = 23;
            gbCatgoryInfo.TabStop = false;
            gbCatgoryInfo.Text = " Category Info ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(115, 181);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(266, 92);
            txtDescription.TabIndex = 2;
            // 
            // txtBookGenreType
            // 
            txtBookGenreType.Location = new Point(115, 120);
            txtBookGenreType.Margin = new Padding(3, 2, 3, 2);
            txtBookGenreType.Name = "txtBookGenreType";
            txtBookGenreType.Size = new Size(266, 23);
            txtBookGenreType.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(115, 64);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 0;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(15, 181);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblBookGenreType
            // 
            lblBookGenreType.AutoSize = true;
            lblBookGenreType.Location = new Point(15, 120);
            lblBookGenreType.Name = "lblBookGenreType";
            lblBookGenreType.Size = new Size(89, 15);
            lblBookGenreType.TabIndex = 1;
            lblBookGenreType.Text = "BookGenreType";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(15, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // dgvCateList
            // 
            dgvCateList.BackgroundColor = Color.Gray;
            dgvCateList.BorderStyle = BorderStyle.Fixed3D;
            dgvCateList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCateList.GridColor = SystemColors.ButtonShadow;
            dgvCateList.Location = new Point(438, 156);
            dgvCateList.Margin = new Padding(3, 2, 3, 2);
            dgvCateList.Name = "dgvCateList";
            dgvCateList.RowHeadersWidth = 51;
            dgvCateList.RowTemplate.Height = 29;
            dgvCateList.Size = new Size(344, 128);
            dgvCateList.TabIndex = 24;
            dgvCateList.SelectionChanged += dgvCateList_SelectionChanged;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Black;
            gbSearch.Location = new Point(421, 15);
            gbSearch.Margin = new Padding(3, 2, 3, 2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(367, 57);
            gbSearch.TabIndex = 25;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Fuchsia;
            btnSearch.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(279, 26);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(16, 27);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(53, 15);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(75, 25);
            txtKeyword.Margin = new Padding(3, 2, 3, 2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(193, 23);
            txtKeyword.TabIndex = 0;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.Controls.Add(groupBox2);
            gbTask.ForeColor = Color.Black;
            gbTask.Location = new Point(170, 347);
            gbTask.Margin = new Padding(3, 2, 3, 2);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(3, 2, 3, 2);
            gbTask.Size = new Size(438, 60);
            gbTask.TabIndex = 26;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(340, 26);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(231, 26);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(123, 26);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(15, 26);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(0, -343);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(438, 334);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = " BookModel Info ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 224);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 224);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 295);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(115, 188);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 257);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(115, 96);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(309, 78);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(115, 64);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(309, 23);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ControlLightLight;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(115, 32);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 296);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 259);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 225);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 225);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 191);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 3;
            label6.Text = "Released Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 97);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 2;
            label7.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 66);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 1;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(15, 33);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 0;
            label9.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(549, 101);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 19;
            label1.Text = "List Categroy";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(gbTask);
            Controls.Add(gbSearch);
            Controls.Add(dgvCateList);
            Controls.Add(gbCatgoryInfo);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            gbCatgoryInfo.ResumeLayout(false);
            gbCatgoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCateList).EndInit();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbTask.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCatgoryInfo;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblDesc;
        private Label lblBookGenreType;
        private Label lblId;
        private DataGridView dgvBookList;
        private GroupBox gbSearch;
        private Button btnSearch;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgvCateList;
        private Label label1;
        private TextBox txtBookGenreType;
    }
}