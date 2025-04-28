namespace BJMicro_Accounts_Refactor.Forms
{
    partial class ItemCategoryMaster
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            label15 = new Label();
            label4 = new Label();
            button13 = new Button();
            lblHiddenId = new Label();
            lblhiddenCategoryName = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            lblTotalRows = new Label();
            label5 = new Label();
            txtPrefix = new TextBox();
            txtCategoryName = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            lblError = new Label();
            label1 = new Label();
            btnCreate = new Button();
            label2 = new Label();
            btnClear = new Button();
            SidePanel2 = new Panel();
            dgCategoryList = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategoryList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewImageColumn1.HeaderText = "Action";
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(23, 627);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(270, 17);
            label15.TabIndex = 44;
            label15.Text = "* Note : Double-Click on any one row to EDIT.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 209);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 36;
            label4.Text = "Category List";
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button13.DialogResult = DialogResult.Cancel;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(839, 3);
            button13.Margin = new Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new Size(37, 40);
            button13.TabIndex = 34;
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // lblHiddenId
            // 
            lblHiddenId.AutoSize = true;
            lblHiddenId.Font = new Font("Century Gothic", 11.25F);
            lblHiddenId.ForeColor = SystemColors.ControlDark;
            lblHiddenId.Location = new Point(534, 624);
            lblHiddenId.Margin = new Padding(4, 0, 4, 0);
            lblHiddenId.Name = "lblHiddenId";
            lblHiddenId.Size = new Size(88, 20);
            lblHiddenId.TabIndex = 29;
            lblHiddenId.Text = "Hidden Id: ";
            lblHiddenId.Visible = false;
            // 
            // lblhiddenCategoryName
            // 
            lblhiddenCategoryName.AutoSize = true;
            lblhiddenCategoryName.Font = new Font("Century Gothic", 11.25F);
            lblhiddenCategoryName.ForeColor = SystemColors.ControlDark;
            lblhiddenCategoryName.Location = new Point(345, 624);
            lblhiddenCategoryName.Margin = new Padding(4, 0, 4, 0);
            lblhiddenCategoryName.Name = "lblhiddenCategoryName";
            lblhiddenCategoryName.Size = new Size(148, 20);
            lblhiddenCategoryName.TabIndex = 29;
            lblhiddenCategoryName.Text = "Hidden Cat Name: ";
            lblhiddenCategoryName.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Location = new Point(27, 241);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(175, 3);
            panel5.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotalRows);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPrefix);
            panel2.Controls.Add(txtCategoryName);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button13);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(lblHiddenId);
            panel2.Controls.Add(lblhiddenCategoryName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(SidePanel2);
            panel2.Controls.Add(dgCategoryList);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(4, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 653);
            panel2.TabIndex = 42;
            panel2.Paint += panel2_Paint;
            // 
            // lblTotalRows
            // 
            lblTotalRows.AutoSize = true;
            lblTotalRows.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRows.Location = new Point(784, 625);
            lblTotalRows.Margin = new Padding(4, 0, 4, 0);
            lblTotalRows.Name = "lblTotalRows";
            lblTotalRows.Size = new Size(14, 16);
            lblTotalRows.TabIndex = 126;
            lblTotalRows.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(688, 624);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 16);
            label5.TabIndex = 127;
            label5.Text = "Total Rows : ";
            // 
            // txtPrefix
            // 
            txtPrefix.Font = new Font("Century Gothic", 11.25F);
            txtPrefix.Location = new Point(188, 126);
            txtPrefix.Margin = new Padding(4, 3, 4, 3);
            txtPrefix.MaxLength = 50;
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(661, 26);
            txtPrefix.TabIndex = 125;
            txtPrefix.Enter += txtPrefix_Enter;
            txtPrefix.KeyDown += txtPrefix_KeyDown;
            txtPrefix.KeyPress += txtCategoryName_KeyPress;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Century Gothic", 11.25F);
            txtCategoryName.Location = new Point(188, 75);
            txtCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtCategoryName.MaxLength = 50;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(661, 26);
            txtCategoryName.TabIndex = 125;
            txtCategoryName.Enter += txtCategoryName_Enter;
            txtCategoryName.KeyDown += txtCategoryName_KeyDown;
            txtCategoryName.KeyPress += txtCategoryName_KeyPress;
            txtCategoryName.KeyUp += txtCategoryName_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 36;
            label3.Text = "Add Category";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(lblError);
            panel3.Location = new Point(188, 168);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 37);
            panel3.TabIndex = 40;
            panel3.Visible = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Century Gothic", 11.25F);
            lblError.Location = new Point(4, 7);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(152, 20);
            lblError.TabIndex = 0;
            lblError.Text = "Confirm Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.Location = new Point(19, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 30;
            label1.Text = "Category Name : ";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DeepSkyBlue;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(644, 168);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(99, 37);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(19, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 29;
            label2.Text = "Item Prefix : ";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Crimson;
            btnClear.DialogResult = DialogResult.Cancel;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(750, 168);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 37);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // SidePanel2
            // 
            SidePanel2.BackColor = Color.Goldenrod;
            SidePanel2.Location = new Point(5, 74);
            SidePanel2.Margin = new Padding(4, 3, 4, 3);
            SidePanel2.Name = "SidePanel2";
            SidePanel2.Size = new Size(6, 39);
            SidePanel2.TabIndex = 31;
            // 
            // dgCategoryList
            // 
            dgCategoryList.AllowUserToAddRows = false;
            dgCategoryList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F);
            dgCategoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgCategoryList.BackgroundColor = Color.WhiteSmoke;
            dgCategoryList.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategoryList.Columns.AddRange(new DataGridViewColumn[] { SrNo, Column1, Column2, Column3, Column4, Column5, Delete });
            dgCategoryList.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgCategoryList.DefaultCellStyle = dataGridViewCellStyle6;
            dgCategoryList.Location = new Point(27, 252);
            dgCategoryList.Margin = new Padding(4, 3, 4, 3);
            dgCategoryList.Name = "dgCategoryList";
            dgCategoryList.ReadOnly = true;
            dgCategoryList.Size = new Size(825, 369);
            dgCategoryList.TabIndex = 37;
            dgCategoryList.CellContentClick += dtCategoryList_CellContentClick;
            dgCategoryList.DoubleClick += dtCategoryList_DoubleClick;
            // 
            // SrNo
            // 
            SrNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SrNo.DataPropertyName = "cId";
            SrNo.HeaderText = "SrNo";
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            SrNo.Visible = false;
            SrNo.Width = 40;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "rowNo";
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "cName";
            Column2.HeaderText = "Category Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "prefix";
            Column3.HeaderText = "Prefix";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "createdDate";
            Column4.HeaderText = "CreatedDate";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "updatedDate";
            Column5.HeaderText = "UpdatedDate";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Delete.HeaderText = "Action";
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 50;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.Location = new Point(12, 46);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 3);
            panel4.TabIndex = 35;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ItemCategoryMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 663);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ItemCategoryMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryMaster";
            Load += ItemCategoryMaster_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategoryList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblHiddenId;
        private System.Windows.Forms.Label lblhiddenCategoryName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel SidePanel2;
        private System.Windows.Forms.DataGridView dgCategoryList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.Label label5;
    }
}