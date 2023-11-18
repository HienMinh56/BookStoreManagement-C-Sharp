namespace BookStore_MinhDLH
{
    partial class BookManagerForm
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
            lblId = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblReleasedDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            cboCategory = new ComboBox();
            gbBookInfo = new GroupBox();
            btnModify = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtKeyword = new TextBox();
            lblKeyword = new Label();
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
            gbSearch = new GroupBox();
            btnSearch = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            lblFormTitle = new Label();
            lblHello = new Label();
            groupBox1 = new GroupBox();
            cboCateSearch = new ComboBox();
            btnCateSearch = new Button();
            label1 = new Label();
            gbBookInfo.SuspendLayout();
            gbTask.SuspendLayout();
            groupBox2.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(15, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(15, 98);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(15, 192);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(80, 15);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 226);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(254, 226);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 260);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 297);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(115, 32);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 64);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 23);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(115, 96);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(309, 78);
            txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(115, 257);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(309, 23);
            txtAuthor.TabIndex = 6;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(115, 188);
            dtpReleasedDate.Margin = new Padding(3, 2, 3, 2);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(134, 23);
            dtpReleasedDate.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(115, 295);
            cboCategory.Margin = new Padding(3, 2, 3, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(198, 23);
            cboCategory.TabIndex = 7;
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(btnModify);
            gbBookInfo.Controls.Add(txtPrice);
            gbBookInfo.Controls.Add(txtQuantity);
            gbBookInfo.Controls.Add(cboCategory);
            gbBookInfo.Controls.Add(dtpReleasedDate);
            gbBookInfo.Controls.Add(txtAuthor);
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblPrice);
            gbBookInfo.Controls.Add(lblQuantity);
            gbBookInfo.Controls.Add(lblReleasedDate);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Black;
            gbBookInfo.Location = new Point(22, 68);
            gbBookInfo.Margin = new Padding(3, 2, 3, 2);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(3, 2, 3, 2);
            gbBookInfo.Size = new Size(438, 334);
            gbBookInfo.TabIndex = 18;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " BookModel Info ";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Cyan;
            btnModify.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModify.Location = new Point(331, 297);
            btnModify.Margin = new Padding(3, 2, 3, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(82, 22);
            btnModify.TabIndex = 8;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(314, 224);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(115, 224);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(80, 26);
            txtKeyword.Margin = new Padding(3, 2, 3, 2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(290, 23);
            txtKeyword.TabIndex = 0;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(16, 28);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(53, 15);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.Controls.Add(groupBox2);
            gbTask.ForeColor = Color.Black;
            gbTask.Location = new Point(22, 411);
            gbTask.Margin = new Padding(3, 2, 3, 2);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(3, 2, 3, 2);
            gbTask.Size = new Size(438, 60);
            gbTask.TabIndex = 20;
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
            label2.Location = new Point(15, 297);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 260);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 226);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 226);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 192);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 3;
            label6.Text = "Released Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 98);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 2;
            label7.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 67);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 1;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(15, 34);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 0;
            label9.Text = "ID";
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Black;
            gbSearch.Location = new Point(494, 68);
            gbSearch.Margin = new Padding(3, 2, 3, 2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(464, 60);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Fuchsia;
            btnSearch.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(376, 27);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = Color.Gray;
            dgvBookList.BorderStyle = BorderStyle.Fixed3D;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.GridColor = SystemColors.ButtonShadow;
            dgvBookList.Location = new Point(500, 260);
            dgvBookList.Margin = new Padding(3, 2, 3, 2);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(458, 252);
            dgvBookList.TabIndex = 0;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Black;
            lblBookList.Location = new Point(494, 227);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(89, 15);
            lblBookList.TabIndex = 23;
            lblBookList.Text = "BookModel List";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Black;
            lblFormTitle.Location = new Point(22, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(158, 37);
            lblFormTitle.TabIndex = 18;
            lblFormTitle.Text = "Book Store";
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(632, 21);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(0, 15);
            lblHello.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCateSearch);
            groupBox1.Controls.Add(btnCateSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(494, 150);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(464, 60);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = " Search ";
            // 
            // cboCateSearch
            // 
            cboCateSearch.FormattingEnabled = true;
            cboCateSearch.Location = new Point(80, 24);
            cboCateSearch.Margin = new Padding(3, 2, 3, 2);
            cboCateSearch.Name = "cboCateSearch";
            cboCateSearch.Size = new Size(290, 23);
            cboCateSearch.TabIndex = 19;
            // 
            // btnCateSearch
            // 
            btnCateSearch.BackColor = Color.Fuchsia;
            btnCateSearch.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCateSearch.Location = new Point(376, 25);
            btnCateSearch.Margin = new Padding(3, 2, 3, 2);
            btnCateSearch.Name = "btnCateSearch";
            btnCateSearch.Size = new Size(82, 22);
            btnCateSearch.TabIndex = 1;
            btnCateSearch.Text = "Search";
            btnCateSearch.UseVisualStyleBackColor = false;
            btnCateSearch.Click += btnCateSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 18;
            label1.Text = "Category";
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 539);
            Controls.Add(groupBox1);
            Controls.Add(lblHello);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookModel Manager";
            FormClosed += BookManagerForm_FormClosed;
            Load += BookManagerForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            gbTask.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblDesc;
        private Label lblReleasedDate;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategory;
        private GroupBox gbBookInfo;
        private TextBox txtKeyword;
        private Label lblKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Button btnSearch;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Label lblFormTitle;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label lblHello;
        private GroupBox groupBox1;
        private Button btnCateSearch;
        private ComboBox cboCateSearch;
        private Label label1;
        private Button btnModify;
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
    }
}