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
            dtgView = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblIdTask = new Label();
            txtIdTaskDelete = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtIdSelect = new TextBox();
            lblId = new Label();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 119);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 52);
            txtDescription.TabIndex = 1;
            // 
            // dtStartDate
            // 
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(100, 199);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(129, 23);
            dtStartDate.TabIndex = 2;
            dtStartDate.Value = new DateTime(2025, 8, 23, 0, 0, 0, 0);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(55, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(27, 122);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(36, 205);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(100, 243);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(370, 557);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 8;
            btnList.Text = "List tasks";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dtgView
            // 
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Columns.AddRange(new DataGridViewColumn[] { colName, Description, CreateDate, StartDate, FinishDate, Status });
            dtgView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgView.Location = new Point(29, 292);
            dtgView.Name = "dtgView";
            dtgView.Size = new Size(789, 250);
            dtgView.TabIndex = 9;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
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
            // lblIdTask
            // 
            lblIdTask.AutoSize = true;
            lblIdTask.Location = new Point(528, 22);
            lblIdTask.Name = "lblIdTask";
            lblIdTask.Size = new Size(43, 15);
            lblIdTask.TabIndex = 10;
            lblIdTask.Text = "Task ID";
            // 
            // txtIdTaskDelete
            // 
            txtIdTaskDelete.Location = new Point(577, 19);
            txtIdTaskDelete.Name = "txtIdTaskDelete";
            txtIdTaskDelete.Size = new Size(72, 23);
            txtIdTaskDelete.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(673, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(276, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtIdSelect
            // 
            txtIdSelect.Location = new Point(100, 27);
            txtIdSelect.Name = "txtIdSelect";
            txtIdSelect.Size = new Size(100, 23);
            txtIdSelect.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(77, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 15;
            lblId.Text = "Id";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(223, 26);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 16;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 588);
            Controls.Add(btnSelect);
            Controls.Add(lblId);
            Controls.Add(txtIdSelect);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtIdTaskDelete);
            Controls.Add(lblIdTask);
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
        private DataGridView dtgView;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn FinishDate;
        private DataGridViewTextBoxColumn Status;
        private Label lblIdTask;
        private TextBox txtIdTaskDelete;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtIdSelect;
        private Label lblId;
        private Button btnSelect;
    }
}
