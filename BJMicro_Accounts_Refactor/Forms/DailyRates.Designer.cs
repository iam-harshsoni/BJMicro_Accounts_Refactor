namespace BJMicro_Accounts_Refactor.Forms
{
    partial class DailyRates
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
            panel1 = new Panel();
            label8 = new Label();
            txt18c = new TextBox();
            panel3 = new Panel();
            lblError = new Label();
            btnCreate = new Button();
            btnClear = new Button();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtSilver = new TextBox();
            txt23c = new TextBox();
            txt22c = new TextBox();
            txtBuyBack = new TextBox();
            txtHallMark = new TextBox();
            txtFineGold = new TextBox();
            SidePanel2 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            button13 = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt18c);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSilver);
            panel1.Controls.Add(txt23c);
            panel1.Controls.Add(txt22c);
            panel1.Controls.Add(txtBuyBack);
            panel1.Controls.Add(txtHallMark);
            panel1.Controls.Add(txtFineGold);
            panel1.Controls.Add(SidePanel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button13);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 421);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F);
            label8.Location = new Point(24, 255);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 46;
            label8.Text = "18c : ";
            // 
            // txt18c
            // 
            txt18c.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt18c.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt18c.Font = new Font("Century Gothic", 11.25F);
            txt18c.Location = new Point(287, 252);
            txt18c.Margin = new Padding(4, 3, 4, 3);
            txt18c.MaxLength = 12;
            txt18c.Name = "txt18c";
            txt18c.Size = new Size(286, 26);
            txt18c.TabIndex = 5;
            txt18c.Enter += txt18c_Enter;
            txt18c.KeyDown += txt18c_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(lblError);
            panel3.Location = new Point(16, 366);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 37);
            panel3.TabIndex = 44;
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
            // btnCreate
            // 
            btnCreate.BackColor = Color.DeepSkyBlue;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(369, 322);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(99, 37);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Crimson;
            btnClear.DialogResult = DialogResult.Cancel;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(475, 322);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 37);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F);
            label7.Location = new Point(24, 291);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 41;
            label7.Text = "Silver fine 1kg : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.Location = new Point(24, 182);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 41;
            label5.Text = "22c 10g : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(24, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 41;
            label2.Text = "916 HallMark 10g : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F);
            label6.Location = new Point(24, 219);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 41;
            label6.Text = "23c 10g : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.Location = new Point(24, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(212, 20);
            label4.TabIndex = 41;
            label4.Text = "916 HallMark buyback 10g : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.Location = new Point(24, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 41;
            label1.Text = "999 Fine Gold(100 g) : ";
            // 
            // txtSilver
            // 
            txtSilver.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSilver.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSilver.Font = new Font("Century Gothic", 11.25F);
            txtSilver.Location = new Point(287, 287);
            txtSilver.Margin = new Padding(4, 3, 4, 3);
            txtSilver.MaxLength = 12;
            txtSilver.Name = "txtSilver";
            txtSilver.Size = new Size(286, 26);
            txtSilver.TabIndex = 6;
            txtSilver.Enter += txtSilver_Enter;
            txtSilver.KeyDown += txtSilver_KeyDown;
            txtSilver.KeyPress += txtBuyBack_KeyPress;
            // 
            // txt23c
            // 
            txt23c.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt23c.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt23c.Font = new Font("Century Gothic", 11.25F);
            txt23c.Location = new Point(287, 216);
            txt23c.Margin = new Padding(4, 3, 4, 3);
            txt23c.MaxLength = 12;
            txt23c.Name = "txt23c";
            txt23c.Size = new Size(286, 26);
            txt23c.TabIndex = 4;
            txt23c.Enter += txt23c_Enter;
            txt23c.KeyDown += txt23c_KeyDown;
            txt23c.KeyPress += txtBuyBack_KeyPress;
            // 
            // txt22c
            // 
            txt22c.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt22c.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt22c.Font = new Font("Century Gothic", 11.25F);
            txt22c.Location = new Point(287, 179);
            txt22c.Margin = new Padding(4, 3, 4, 3);
            txt22c.MaxLength = 12;
            txt22c.Name = "txt22c";
            txt22c.Size = new Size(286, 26);
            txt22c.TabIndex = 3;
            txt22c.Enter += txt22c_Enter;
            txt22c.KeyDown += txt22c_KeyDown;
            txt22c.KeyPress += txtBuyBack_KeyPress;
            // 
            // txtBuyBack
            // 
            txtBuyBack.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuyBack.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuyBack.Font = new Font("Century Gothic", 11.25F);
            txtBuyBack.Location = new Point(287, 142);
            txtBuyBack.Margin = new Padding(4, 3, 4, 3);
            txtBuyBack.MaxLength = 12;
            txtBuyBack.Name = "txtBuyBack";
            txtBuyBack.Size = new Size(286, 26);
            txtBuyBack.TabIndex = 2;
            txtBuyBack.Enter += txtBuyBack_Enter;
            txtBuyBack.KeyDown += txtBuyBack_KeyDown;
            txtBuyBack.KeyPress += txtBuyBack_KeyPress;
            // 
            // txtHallMark
            // 
            txtHallMark.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtHallMark.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtHallMark.Font = new Font("Century Gothic", 11.25F);
            txtHallMark.Location = new Point(287, 105);
            txtHallMark.Margin = new Padding(4, 3, 4, 3);
            txtHallMark.MaxLength = 12;
            txtHallMark.Name = "txtHallMark";
            txtHallMark.Size = new Size(286, 26);
            txtHallMark.TabIndex = 1;
            txtHallMark.Enter += txtHallMark_Enter;
            txtHallMark.KeyDown += txtHallMark_KeyDown;
            txtHallMark.KeyPress += txtHallMark_KeyPress;
            // 
            // txtFineGold
            // 
            txtFineGold.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFineGold.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFineGold.Font = new Font("Century Gothic", 11.25F);
            txtFineGold.Location = new Point(287, 69);
            txtFineGold.Margin = new Padding(4, 3, 4, 3);
            txtFineGold.MaxLength = 12;
            txtFineGold.Name = "txtFineGold";
            txtFineGold.Size = new Size(286, 26);
            txtFineGold.TabIndex = 0;
            txtFineGold.FontChanged += txt999_FontChanged;
            txtFineGold.Enter += txt999_Enter;
            txtFineGold.KeyDown += txt999_KeyDown;
            txtFineGold.KeyPress += txt999_KeyPress;
            // 
            // SidePanel2
            // 
            SidePanel2.BackColor = Color.Goldenrod;
            SidePanel2.Location = new Point(16, 60);
            SidePanel2.Margin = new Padding(4, 3, 4, 3);
            SidePanel2.Name = "SidePanel2";
            SidePanel2.Size = new Size(6, 39);
            SidePanel2.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 7);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 38;
            label3.Text = "Daily Rates";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.Location = new Point(12, 42);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 3);
            panel4.TabIndex = 37;
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
            button13.Location = new Point(545, 3);
            button13.Margin = new Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new Size(37, 40);
            button13.TabIndex = 35;
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DailyRates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = button13;
            ClientSize = new Size(589, 423);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DailyRates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DailyGoldRates";
            Load += DailyRates_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSilver;
        private System.Windows.Forms.TextBox txt23c;
        private System.Windows.Forms.TextBox txt22c;
        private System.Windows.Forms.TextBox txtBuyBack;
        private System.Windows.Forms.TextBox txtHallMark;
        private System.Windows.Forms.TextBox txtFineGold;
        private System.Windows.Forms.Panel SidePanel2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt18c;
    }
}