namespace DentistApplication.Forms
{
    partial class AddServiceForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvServices = new DataGridView();
            btnAddNewService = new Button();
            btnOffer = new Button();
            gbNewService = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtServicePrice = new TextBox();
            txtServiceName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            gbNewService.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = Color.FromArgb(212, 207, 195);
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle1;
            dgvServices.Location = new Point(86, 141);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 45;
            dgvServices.Size = new Size(926, 631);
            dgvServices.TabIndex = 0;
            dgvServices.CellDoubleClick += dgvServices_CellDoubleClick;
            // 
            // btnAddNewService
            // 
            btnAddNewService.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNewService.BackColor = Color.FromArgb(13, 73, 81);
            btnAddNewService.Font = new Font("Segoe UI", 12F);
            btnAddNewService.ForeColor = Color.White;
            btnAddNewService.Location = new Point(86, 52);
            btnAddNewService.Name = "btnAddNewService";
            btnAddNewService.Size = new Size(230, 73);
            btnAddNewService.TabIndex = 1;
            btnAddNewService.Text = "Додај Услуга";
            btnAddNewService.UseVisualStyleBackColor = false;
            btnAddNewService.Click += btnAddNewService_Click;
            // 
            // btnOffer
            // 
            btnOffer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOffer.BackColor = Color.FromArgb(13, 73, 81);
            btnOffer.Font = new Font("Segoe UI", 12F);
            btnOffer.ForeColor = Color.White;
            btnOffer.Location = new Point(782, 52);
            btnOffer.Name = "btnOffer";
            btnOffer.Size = new Size(230, 73);
            btnOffer.TabIndex = 2;
            btnOffer.Text = "Креирај понуда";
            btnOffer.UseVisualStyleBackColor = false;
            // 
            // gbNewService
            // 
            gbNewService.Anchor = AnchorStyles.None;
            gbNewService.Controls.Add(button2);
            gbNewService.Controls.Add(button1);
            gbNewService.Controls.Add(label2);
            gbNewService.Controls.Add(label1);
            gbNewService.Controls.Add(txtServicePrice);
            gbNewService.Controls.Add(txtServiceName);
            gbNewService.ForeColor = Color.FromArgb(13, 73, 81);
            gbNewService.Location = new Point(204, 201);
            gbNewService.Name = "gbNewService";
            gbNewService.Size = new Size(678, 386);
            gbNewService.TabIndex = 3;
            gbNewService.TabStop = false;
            gbNewService.Text = "Додај Услуга";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(624, 26);
            button2.Name = "button2";
            button2.Size = new Size(37, 36);
            button2.TabIndex = 5;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(13, 73, 81);
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(189, 254);
            button1.Name = "button1";
            button1.Size = new Size(311, 48);
            button1.TabIndex = 4;
            button1.Text = "Зачувај Услуга";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(244, 148);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(244, 64);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 2;
            label1.Text = "Име";
            // 
            // txtServicePrice
            // 
            txtServicePrice.Anchor = AnchorStyles.None;
            txtServicePrice.Location = new Point(244, 179);
            txtServicePrice.MinimumSize = new Size(200, 50);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(200, 50);
            txtServicePrice.TabIndex = 1;
            // 
            // txtServiceName
            // 
            txtServiceName.Anchor = AnchorStyles.None;
            txtServiceName.Location = new Point(244, 95);
            txtServiceName.MinimumSize = new Size(200, 50);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(200, 50);
            txtServiceName.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 73, 81);
            label3.Location = new Point(425, 52);
            label3.Name = "label3";
            label3.Size = new Size(223, 78);
            label3.TabIndex = 4;
            label3.Text = "Услуги";
            // 
            // AddServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 233);
            ClientSize = new Size(1090, 801);
            Controls.Add(label3);
            Controls.Add(gbNewService);
            Controls.Add(btnOffer);
            Controls.Add(btnAddNewService);
            Controls.Add(dgvServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddServiceForm";
            Text = "AddServiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            gbNewService.ResumeLayout(false);
            gbNewService.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServices;
        private Button btnAddNewService;
        private Button btnOffer;
        private GroupBox gbNewService;
        private TextBox txtServicePrice;
        private TextBox txtServiceName;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}