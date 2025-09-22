namespace TasksWithBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtDescription = new TextBox();
            dtStartDate = new DateTimePicker();
            lblName = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            btnCreate = new Button();
            btnList = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtIdSelect = new TextBox();
            lblId = new Label();
            btnSelect = new Button();
            dtgView = new DataGridView();
            label2 = new Label();
            listStatus = new ComboBox();
            Id = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(101, 115);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 71);
            txtDescription.TabIndex = 1;
            // 
            // dtStartDate
            // 
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(101, 210);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(129, 23);
            dtStartDate.TabIndex = 2;
            dtStartDate.Value = new DateTime(2025, 8, 23, 0, 0, 0, 0);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(56, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(28, 118);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(37, 216);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(191, 250);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(476, 612);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 8;
            btnList.Text = "List tasks";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(623, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(704, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtIdSelect
            // 
            txtIdSelect.Location = new Point(419, 13);
            txtIdSelect.Name = "txtIdSelect";
            txtIdSelect.Size = new Size(100, 23);
            txtIdSelect.TabIndex = 14;
            txtIdSelect.TextChanged += txtIdSelect_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(396, 16);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 15;
            lblId.Text = "Id";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(542, 12);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 16;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // dtgView
            // 
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Columns.AddRange(new DataGridViewColumn[] { Id, colName, Description, CreateDate, StartDate, FinishDate, Status });
            dtgView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgView.Location = new Point(12, 292);
            dtgView.MultiSelect = false;
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgView.Size = new Size(1042, 314);
            dtgView.TabIndex = 9;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 71);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Status";
            // 
            // listStatus
            // 
            listStatus.Enabled = false;
            listStatus.FormattingEnabled = true;
            listStatus.Items.AddRange(new object[] { "Pending", "InProgress", "Finished", "Cancelled" });
            listStatus.Location = new Point(444, 68);
            listStatus.Name = "listStatus";
            listStatus.Size = new Size(129, 23);
            listStatus.TabIndex = 20;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 42;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.Frozen = true;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.Width = 64;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.Width = 92;
            // 
            // CreateDate
            // 
            CreateDate.DataPropertyName = "CreateDate";
            CreateDate.HeaderText = "Create Date";
            CreateDate.Name = "CreateDate";
            CreateDate.Width = 93;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Start Date";
            StartDate.Name = "StartDate";
            StartDate.Width = 83;
            // 
            // FinishDate
            // 
            FinishDate.DataPropertyName = "FinishDate";
            FinishDate.HeaderText = "Finish Date";
            FinishDate.Name = "FinishDate";
            FinishDate.Width = 90;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 64;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 647);
            Controls.Add(listStatus);
            Controls.Add(label2);
            Controls.Add(btnSelect);
            Controls.Add(lblId);
            Controls.Add(txtIdSelect);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dtgView);
            Controls.Add(btnList);
            Controls.Add(btnCreate);
            Controls.Add(lblStartDate);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(dtStartDate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker dtStartDate;
        private Label lblName;
        private Label lblDescription;
        private Label lblStartDate;
        private Button btnCreate;
        private Button btnList;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtIdSelect;
        private Label lblId;
        private Button btnSelect;
        private DataGridView dtgView;
        private Label label2;
        private ComboBox listStatus;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn FinishDate;
        private DataGridViewTextBoxColumn Status;
    }
}
