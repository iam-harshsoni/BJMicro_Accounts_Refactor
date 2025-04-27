namespace BJMicro_Accounts_Refactor.UserControls
{
    partial class DashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dgDailyRateReport = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblFine = new Label();
            lblhallMarkBuyBack = new Label();
            lbl23C = new Label();
            lblHallMark = new Label();
            lbl22C = new Label();
            lblSilver = new Label();
            btnClear = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            btnSearch = new Button();
            btnEnterRates = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgDailyRateReport).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgDailyRateReport
            // 
            dgDailyRateReport.AllowUserToAddRows = false;
            dgDailyRateReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgDailyRateReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgDailyRateReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDailyRateReport.BackgroundColor = Color.WhiteSmoke;
            dgDailyRateReport.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Goldenrod;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgDailyRateReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgDailyRateReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDailyRateReport.Columns.AddRange(new DataGridViewColumn[] { Column1, Column8, Column2, Column6, Column4, Column5, Column7, Column9, Column10 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgDailyRateReport.DefaultCellStyle = dataGridViewCellStyle11;
            dgDailyRateReport.EnableHeadersVisualStyles = false;
            dgDailyRateReport.Location = new Point(18, 107);
            dgDailyRateReport.Margin = new Padding(4, 3, 4, 3);
            dgDailyRateReport.Name = "dgDailyRateReport";
            dgDailyRateReport.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgDailyRateReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgDailyRateReport.Size = new Size(1116, 559);
            dgDailyRateReport.TabIndex = 127;
            dgDailyRateReport.CellContentClick += dgPurchaseReport_CellContentClick;
            dgDailyRateReport.DoubleClick += dgDailyRateReport_DoubleClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "SrNo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column8.DataPropertyName = "rowNo";
            Column8.HeaderText = "#";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 39;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "date";
            Column2.HeaderText = "Date";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column6.DataPropertyName = "fineGoldFormatted";
            Column6.HeaderText = "999 Fine Gold 100g";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 77;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.DataPropertyName = "hallmarkFormatted";
            Column4.HeaderText = "916 HallMark 10g";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 110;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.DataPropertyName = "hallmarkBuyBackFormatted";
            Column5.HeaderText = "916 HallMark BuyBack 10g";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 102;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column7.DataPropertyName = "twentyTwoCFormatted";
            Column7.HeaderText = "22c 10g";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 73;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column9.DataPropertyName = "twentyThreeCFormatted";
            Column9.HeaderText = "23c 10g";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 73;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column10.DataPropertyName = "silverFormatted";
            Column10.HeaderText = "Silver 1kg";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 128;
            label1.Text = "Today's Rates";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Location = new Point(7, 33);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 2);
            panel1.TabIndex = 129;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F);
            label7.Location = new Point(7, 243);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 130;
            label7.Text = "Silver fine 1kg : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.Location = new Point(7, 170);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 131;
            label5.Text = "22c 10g : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(7, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 132;
            label2.Text = "916 HallMark 10g : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F);
            label6.Location = new Point(7, 207);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 133;
            label6.Text = "23c 10g : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.Location = new Point(7, 133);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(212, 20);
            label4.TabIndex = 134;
            label4.Text = "916 HallMark buyback 10g : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(7, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 135;
            label3.Text = "999 Fine Gold(100 g) : ";
            // 
            // lblFine
            // 
            lblFine.AutoSize = true;
            lblFine.Font = new Font("Century Gothic", 11.25F);
            lblFine.Location = new Point(247, 60);
            lblFine.Margin = new Padding(4, 0, 4, 0);
            lblFine.Name = "lblFine";
            lblFine.Size = new Size(37, 20);
            lblFine.TabIndex = 135;
            lblFine.Text = "0.00";
            // 
            // lblhallMarkBuyBack
            // 
            lblhallMarkBuyBack.AutoSize = true;
            lblhallMarkBuyBack.Font = new Font("Century Gothic", 11.25F);
            lblhallMarkBuyBack.Location = new Point(247, 134);
            lblhallMarkBuyBack.Margin = new Padding(4, 0, 4, 0);
            lblhallMarkBuyBack.Name = "lblhallMarkBuyBack";
            lblhallMarkBuyBack.Size = new Size(37, 20);
            lblhallMarkBuyBack.TabIndex = 134;
            lblhallMarkBuyBack.Text = "0.00";
            // 
            // lbl23C
            // 
            lbl23C.AutoSize = true;
            lbl23C.Font = new Font("Century Gothic", 11.25F);
            lbl23C.Location = new Point(247, 208);
            lbl23C.Margin = new Padding(4, 0, 4, 0);
            lbl23C.Name = "lbl23C";
            lbl23C.Size = new Size(37, 20);
            lbl23C.TabIndex = 133;
            lbl23C.Text = "0.00";
            // 
            // lblHallMark
            // 
            lblHallMark.AutoSize = true;
            lblHallMark.Font = new Font("Century Gothic", 11.25F);
            lblHallMark.Location = new Point(247, 97);
            lblHallMark.Margin = new Padding(4, 0, 4, 0);
            lblHallMark.Name = "lblHallMark";
            lblHallMark.Size = new Size(37, 20);
            lblHallMark.TabIndex = 132;
            lblHallMark.Text = "0.00";
            // 
            // lbl22C
            // 
            lbl22C.AutoSize = true;
            lbl22C.Font = new Font("Century Gothic", 11.25F);
            lbl22C.Location = new Point(247, 171);
            lbl22C.Margin = new Padding(4, 0, 4, 0);
            lbl22C.Name = "lbl22C";
            lbl22C.Size = new Size(37, 20);
            lbl22C.TabIndex = 131;
            lbl22C.Text = "0.00";
            // 
            // lblSilver
            // 
            lblSilver.AutoSize = true;
            lblSilver.Font = new Font("Century Gothic", 11.25F);
            lblSilver.Location = new Point(247, 245);
            lblSilver.Margin = new Padding(4, 0, 4, 0);
            lblSilver.Name = "lblSilver";
            lblSilver.Size = new Size(37, 20);
            lblSilver.TabIndex = 130;
            lblSilver.Text = "0.00";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.Crimson;
            btnClear.DialogResult = DialogResult.Cancel;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(1026, 18);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 37);
            btnClear.TabIndex = 142;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 11.25F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(245, 22);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(167, 26);
            dateTimePicker2.TabIndex = 137;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 11.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(19, 22);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 26);
            dateTimePicker1.TabIndex = 136;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.25F);
            label8.Location = new Point(203, 27);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(23, 19);
            label8.TabIndex = 140;
            label8.Text = "to";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Gold;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(886, 18);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 37);
            btnSearch.TabIndex = 138;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEnterRates
            // 
            btnEnterRates.BackColor = Color.DarkTurquoise;
            btnEnterRates.DialogResult = DialogResult.Cancel;
            btnEnterRates.Enabled = false;
            btnEnterRates.FlatStyle = FlatStyle.Flat;
            btnEnterRates.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnterRates.ForeColor = Color.White;
            btnEnterRates.Location = new Point(14, 301);
            btnEnterRates.Margin = new Padding(4, 3, 4, 3);
            btnEnterRates.Name = "btnEnterRates";
            btnEnterRates.Size = new Size(324, 37);
            btnEnterRates.TabIndex = 143;
            btnEnterRates.Text = "Enter Rates";
            btnEnterRates.UseVisualStyleBackColor = false;
            btnEnterRates.Click += btnEnterRates_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dgDailyRateReport);
            panel2.Location = new Point(358, 39);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1138, 666);
            panel2.TabIndex = 144;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(14, 11);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1116, 65);
            groupBox1.TabIndex = 144;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.Goldenrod;
            panel3.Location = new Point(348, 3);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 700);
            panel3.TabIndex = 145;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label9.Location = new Point(358, 3);
            label9.Name = "label9";
            label9.Size = new Size(204, 25);
            label9.TabIndex = 146;
            label9.Text = "Daily Rate Updates";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Location = new Point(366, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(280, 2);
            panel5.TabIndex = 147;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnEnterRates);
            Controls.Add(lblSilver);
            Controls.Add(label7);
            Controls.Add(lbl22C);
            Controls.Add(label5);
            Controls.Add(lblHallMark);
            Controls.Add(label2);
            Controls.Add(lbl23C);
            Controls.Add(label6);
            Controls.Add(lblhallMarkBuyBack);
            Controls.Add(lblFine);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashBoard";
            Size = new Size(1496, 705);
            Load += DashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dgDailyRateReport).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDailyRateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblhallMarkBuyBack;
        private System.Windows.Forms.Label lbl23C;
        private System.Windows.Forms.Label lblHallMark;
        private System.Windows.Forms.Label lbl22C;
        private System.Windows.Forms.Label lblSilver;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEnterRates;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Label label9;
        private Panel panel5;
    }
}
