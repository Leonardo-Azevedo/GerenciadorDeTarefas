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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtDescription = new TextBox();
            dtStartDate = new DateTimePicker();
            lblName = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            btnList = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dtgView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            listStatus = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            novoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            taskToolStripMenuItem = new ToolStripMenuItem();
            btnSave = new Button();
            txtSearch = new TextBox();
            listStatusSearch = new ComboBox();
            dtFilterStartDate = new DateTimePicker();
            dtFilterEndDate = new DateTimePicker();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(14, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(14, 81);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 74);
            txtDescription.TabIndex = 1;
            // 
            // dtStartDate
            // 
            dtStartDate.Enabled = false;
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(301, 81);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(129, 23);
            dtStartDate.TabIndex = 2;
            dtStartDate.Value = new DateTime(2025, 8, 23, 0, 0, 0, 0);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(14, 63);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(301, 63);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date";
            // 
            // btnList
            // 
            btnList.Location = new Point(773, 98);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 8;
            btnList.Text = "Refresh";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(773, 589);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(692, 589);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtgView
            // 
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Columns.AddRange(new DataGridViewColumn[] { Id, colName, Description, CreateDate, StartDate, FinishDate, Status });
            dtgView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgView.Location = new Point(12, 127);
            dtgView.MultiSelect = false;
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgView.Size = new Size(836, 314);
            dtgView.TabIndex = 9;
            dtgView.CellClick += dtgView_CellClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 10);
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
            listStatus.Location = new Point(301, 28);
            listStatus.Name = "listStatus";
            listStatus.Size = new Size(129, 23);
            listStatus.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { novoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 26);
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(103, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(860, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taskToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 20);
            newToolStripMenuItem.Text = "New";
            // 
            // taskToolStripMenuItem
            // 
            taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            taskToolStripMenuItem.Size = new Size(180, 22);
            taskToolStripMenuItem.Text = "Task";
            taskToolStripMenuItem.Click += taskToolStripMenuItem_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(611, 589);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(373, 23);
            txtSearch.TabIndex = 23;
            // 
            // listStatusSearch
            // 
            listStatusSearch.FormattingEnabled = true;
            listStatusSearch.Items.AddRange(new object[] { "Pending", "InProgress", "Finished", "Cancelled" });
            listStatusSearch.Location = new Point(410, 98);
            listStatusSearch.Name = "listStatusSearch";
            listStatusSearch.Size = new Size(121, 23);
            listStatusSearch.TabIndex = 24;
            listStatusSearch.Tag = "";
            // 
            // dtFilterStartDate
            // 
            dtFilterStartDate.Format = DateTimePickerFormat.Short;
            dtFilterStartDate.Location = new Point(547, 98);
            dtFilterStartDate.Name = "dtFilterStartDate";
            dtFilterStartDate.Size = new Size(105, 23);
            dtFilterStartDate.TabIndex = 25;
            dtFilterStartDate.Value = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // dtFilterEndDate
            // 
            dtFilterEndDate.Format = DateTimePickerFormat.Short;
            dtFilterEndDate.Location = new Point(658, 98);
            dtFilterEndDate.Name = "dtFilterEndDate";
            dtFilterEndDate.Size = new Size(105, 23);
            dtFilterEndDate.TabIndex = 26;
            dtFilterEndDate.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblStartDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(listStatus);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(dtStartDate);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(12, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 171);
            panel1.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 624);
            Controls.Add(panel1);
            Controls.Add(dtFilterEndDate);
            Controls.Add(dtFilterStartDate);
            Controls.Add(listStatusSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(menuStrip1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dtgView);
            Controls.Add(btnList);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnList;
        private Button btnDelete;
        private Button btnEdit;
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
        private Button btnSave;
        private TextBox txtSearch;
        private ComboBox listStatusSearch;
        private DateTimePicker dtFilterStartDate;
        private DateTimePicker dtFilterEndDate;
        private Panel panel1;
    }
}
