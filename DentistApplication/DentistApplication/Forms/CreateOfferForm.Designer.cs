namespace DentistApplication.Forms
{
    partial class CreateOfferForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            cbServices = new ComboBox();
            txtQuantity = new TextBox();
            dgvServices = new DataGridView();
            label1 = new Label();
            labelPrice = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtSearchService = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // cbServices
            // 
            cbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServices.FormattingEnabled = true;
            cbServices.Location = new Point(39, 76);
            cbServices.Name = "cbServices";
            cbServices.Size = new Size(672, 28);
            cbServices.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(753, 75);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(104, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.Text = "1";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = Color.FromArgb(243, 240, 233);
            dgvServices.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(114, 148, 148);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(114, 148, 148);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle4;
            dgvServices.Location = new Point(39, 139);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.ScrollBars = ScrollBars.Vertical;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(1061, 381);
            dgvServices.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 73, 81);
            label1.Location = new Point(49, 534);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 3;
            label1.Text = "Вкупно:";
            // 
            // labelPrice
            // 
            labelPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.FromArgb(13, 73, 81);
            labelPrice.Location = new Point(180, 534);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 38);
            labelPrice.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(12, 76, 84);
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(855, 534);
            button1.Name = "button1";
            button1.Size = new Size(218, 52);
            button1.TabIndex = 10;
            button1.Text = "Печати понуда";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 76, 84);
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(918, 63);
            button2.Name = "button2";
            button2.Size = new Size(182, 46);
            button2.TabIndex = 11;
            button2.Text = "Додај услуга";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(13, 73, 81);
            label2.Location = new Point(39, 17);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 12;
            label2.Text = "Пребарај услуга";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(13, 73, 81);
            label3.Location = new Point(753, 44);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 13;
            label3.Text = "Количина";
            // 
            // txtSearchService
            // 
            txtSearchService.Location = new Point(39, 48);
            txtSearchService.Name = "txtSearchService";
            txtSearchService.Size = new Size(672, 27);
            txtSearchService.TabIndex = 14;
            txtSearchService.TextChanged += textBox1_TextChanged;
            // 
            // CreateOfferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 233);
            ClientSize = new Size(1121, 621);
            Controls.Add(txtSearchService);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelPrice);
            Controls.Add(label1);
            Controls.Add(dgvServices);
            Controls.Add(txtQuantity);
            Controls.Add(cbServices);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CreateOfferForm";
            Text = "Креирај понуда";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbServices;
        private TextBox txtQuantity;
        private DataGridView dgvServices;
        private Label label1;
        private Label labelPrice;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox txtSearchService;
    }
}