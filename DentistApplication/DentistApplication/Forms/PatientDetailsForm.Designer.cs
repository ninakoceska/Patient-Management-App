namespace DentistApplication.Forms
{
    partial class PatientDetailsForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEMBG = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtHomeAddress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            LabelName = new Label();
            btnChangeInfo = new Button();
            txtDescription = new RichTextBox();
            label6 = new Label();
            dgvServices = new DataGridView();
            btnAddService = new Button();
            btnSaveChanges = new Button();
            gbAddService = new GroupBox();
            button1 = new Button();
            label10 = new Label();
            txtServiceDescription = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtPricePayed = new TextBox();
            txtPrice = new TextBox();
            txtServiceName = new TextBox();
            btnCloseAddService = new Button();
            button2 = new Button();
            panelNewService = new Panel();
            cbServices = new ComboBox();
            btnDeletePatientService = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            gbAddService.SuspendLayout();
            panelNewService.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(59, 71);
            txtFirstName.MinimumSize = new Size(250, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 60);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(349, 71);
            txtLastName.MinimumSize = new Size(250, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 60);
            txtLastName.TabIndex = 1;
            // 
            // txtEMBG
            // 
            txtEMBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEMBG.Font = new Font("Segoe UI", 14F);
            txtEMBG.Location = new Point(637, 71);
            txtEMBG.MinimumSize = new Size(250, 60);
            txtEMBG.Name = "txtEMBG";
            txtEMBG.Size = new Size(250, 60);
            txtEMBG.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPhoneNumber.Font = new Font("Segoe UI", 14F);
            txtPhoneNumber.Location = new Point(59, 179);
            txtPhoneNumber.MinimumSize = new Size(250, 60);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(250, 60);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEmailAddress.Font = new Font("Segoe UI", 14F);
            txtEmailAddress.Location = new Point(349, 179);
            txtEmailAddress.MinimumSize = new Size(250, 60);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(250, 60);
            txtEmailAddress.TabIndex = 4;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtHomeAddress.Font = new Font("Segoe UI", 14F);
            txtHomeAddress.Location = new Point(637, 179);
            txtHomeAddress.MinimumSize = new Size(250, 60);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(250, 60);
            txtHomeAddress.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.FromArgb(13, 73, 81);
            label5.Location = new Point(637, 141);
            label5.Name = "label5";
            label5.Size = new Size(98, 35);
            label5.TabIndex = 20;
            label5.Text = "Адреса";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(13, 73, 81);
            label4.Location = new Point(349, 141);
            label4.Name = "label4";
            label4.Size = new Size(87, 35);
            label4.TabIndex = 19;
            label4.Text = "Емаил";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(13, 73, 81);
            label3.Location = new Point(62, 141);
            label3.Name = "label3";
            label3.Size = new Size(113, 35);
            label3.TabIndex = 18;
            label3.Text = "Телефон";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(13, 73, 81);
            label1.Location = new Point(637, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 35);
            label1.TabIndex = 17;
            label1.Text = "ЕМБГ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(13, 73, 81);
            label2.Location = new Point(349, 33);
            label2.Name = "label2";
            label2.Size = new Size(118, 35);
            label2.TabIndex = 16;
            label2.Text = "Презиме";
            // 
            // LabelName
            // 
            LabelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 15F);
            LabelName.ForeColor = Color.FromArgb(13, 73, 81);
            LabelName.Location = new Point(59, 33);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(65, 35);
            LabelName.TabIndex = 15;
            LabelName.Text = "Име";
            // 
            // btnChangeInfo
            // 
            btnChangeInfo.BackColor = Color.FromArgb(13, 73, 81);
            btnChangeInfo.ForeColor = Color.White;
            btnChangeInfo.Location = new Point(59, 266);
            btnChangeInfo.Name = "btnChangeInfo";
            btnChangeInfo.Size = new Size(828, 39);
            btnChangeInfo.TabIndex = 21;
            btnChangeInfo.Text = "Измени лични податоци ";
            btnChangeInfo.UseVisualStyleBackColor = false;
            btnChangeInfo.Click += btnChangeInfo_Click;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDescription.Font = new Font("Segoe UI", 14F);
            txtDescription.Location = new Point(918, 71);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(355, 863);
            txtDescription.TabIndex = 22;
            txtDescription.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.FromArgb(13, 73, 81);
            label6.Location = new Point(918, 33);
            label6.Name = "label6";
            label6.Size = new Size(75, 35);
            label6.TabIndex = 23;
            label6.Text = "Опис";
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvServices.BackgroundColor = Color.FromArgb(212, 220, 220);
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(25, 381);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.Size = new Size(862, 553);
            dgvServices.TabIndex = 24;
            dgvServices.CellDoubleClick += dgvServices_CellDoubleClick;
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.FromArgb(13, 73, 81);
            btnAddService.ForeColor = Color.White;
            btnAddService.Location = new Point(620, 341);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(267, 34);
            btnAddService.TabIndex = 25;
            btnAddService.Text = "Додај нова услуга";
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(157, 180, 176);
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.FromArgb(13, 73, 81);
            btnSaveChanges.Location = new Point(59, 266);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(828, 39);
            btnSaveChanges.TabIndex = 26;
            btnSaveChanges.Text = "Зачувај!";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // gbAddService
            // 
            gbAddService.Controls.Add(btnDeletePatientService);
            gbAddService.Controls.Add(button1);
            gbAddService.Controls.Add(label10);
            gbAddService.Controls.Add(txtServiceDescription);
            gbAddService.Controls.Add(label9);
            gbAddService.Controls.Add(label8);
            gbAddService.Controls.Add(label7);
            gbAddService.Controls.Add(txtPricePayed);
            gbAddService.Controls.Add(txtPrice);
            gbAddService.Controls.Add(txtServiceName);
            gbAddService.Controls.Add(btnCloseAddService);
            gbAddService.Dock = DockStyle.Fill;
            gbAddService.Location = new Point(0, 0);
            gbAddService.Name = "gbAddService";
            gbAddService.Size = new Size(1302, 971);
            gbAddService.TabIndex = 27;
            gbAddService.TabStop = false;
            gbAddService.Text = "Додај услуга";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 76, 84);
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(973, 713);
            button1.Name = "button1";
            button1.Size = new Size(218, 52);
            button1.TabIndex = 9;
            button1.Text = "Зачувај услуга";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.ForeColor = Color.FromArgb(13, 73, 81);
            label10.Location = new Point(111, 381);
            label10.Name = "label10";
            label10.Size = new Size(180, 32);
            label10.TabIndex = 8;
            label10.Text = "Опис на услуга";
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.Font = new Font("Segoe UI", 12F);
            txtServiceDescription.Location = new Point(114, 429);
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(1077, 260);
            txtServiceDescription.TabIndex = 7;
            txtServiceDescription.Text = "";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.FromArgb(13, 73, 81);
            label9.Location = new Point(114, 248);
            label9.Name = "label9";
            label9.Size = new Size(71, 32);
            label9.TabIndex = 6;
            label9.Text = "Цена";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.FromArgb(13, 73, 81);
            label8.Location = new Point(718, 260);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 5;
            label8.Text = "Платено";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.FromArgb(13, 73, 81);
            label7.Location = new Point(111, 134);
            label7.Name = "label7";
            label7.Size = new Size(171, 32);
            label7.TabIndex = 4;
            label7.Text = "Име на услуга";
            // 
            // txtPricePayed
            // 
            txtPricePayed.Anchor = AnchorStyles.None;
            txtPricePayed.Font = new Font("Segoe UI", 13F);
            txtPricePayed.ForeColor = Color.FromArgb(13, 73, 81);
            txtPricePayed.Location = new Point(718, 297);
            txtPricePayed.MinimumSize = new Size(250, 60);
            txtPricePayed.Name = "txtPricePayed";
            txtPricePayed.Size = new Size(500, 60);
            txtPricePayed.TabIndex = 3;
            txtPricePayed.Text = "0";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Font = new Font("Segoe UI", 13F);
            txtPrice.ForeColor = Color.FromArgb(13, 73, 81);
            txtPrice.Location = new Point(114, 297);
            txtPrice.MinimumSize = new Size(250, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(500, 60);
            txtPrice.TabIndex = 2;
            // 
            // txtServiceName
            // 
            txtServiceName.Anchor = AnchorStyles.None;
            txtServiceName.Font = new Font("Segoe UI", 13F);
            txtServiceName.ForeColor = Color.FromArgb(13, 73, 81);
            txtServiceName.Location = new Point(111, 179);
            txtServiceName.MinimumSize = new Size(250, 60);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(500, 60);
            txtServiceName.TabIndex = 1;
            // 
            // btnCloseAddService
            // 
            btnCloseAddService.Anchor = AnchorStyles.None;
            btnCloseAddService.BackColor = Color.FromArgb(13, 73, 81);
            btnCloseAddService.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseAddService.ForeColor = Color.White;
            btnCloseAddService.Location = new Point(1233, 33);
            btnCloseAddService.Name = "btnCloseAddService";
            btnCloseAddService.Size = new Size(40, 40);
            btnCloseAddService.TabIndex = 0;
            btnCloseAddService.Text = "x";
            btnCloseAddService.UseVisualStyleBackColor = false;
            btnCloseAddService.Click += btnCloseAddService_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(13, 73, 81);
            button2.ForeColor = Color.White;
            button2.Location = new Point(303, 341);
            button2.Name = "button2";
            button2.Size = new Size(266, 34);
            button2.TabIndex = 28;
            button2.Text = "Додај постоечка услуга";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelNewService
            // 
            panelNewService.Controls.Add(gbAddService);
            panelNewService.Dock = DockStyle.Fill;
            panelNewService.Location = new Point(0, 0);
            panelNewService.Name = "panelNewService";
            panelNewService.Size = new Size(1302, 971);
            panelNewService.TabIndex = 29;
            // 
            // cbServices
            // 
            cbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServices.FormattingEnabled = true;
            cbServices.Location = new Point(25, 347);
            cbServices.Name = "cbServices";
            cbServices.Size = new Size(272, 28);
            cbServices.TabIndex = 30;
            // 
            // btnDeletePatientService
            // 
            btnDeletePatientService.BackColor = Color.Maroon;
            btnDeletePatientService.Font = new Font("Segoe UI", 13F);
            btnDeletePatientService.ForeColor = Color.White;
            btnDeletePatientService.Location = new Point(1072, 907);
            btnDeletePatientService.Name = "btnDeletePatientService";
            btnDeletePatientService.Size = new Size(218, 52);
            btnDeletePatientService.TabIndex = 10;
            btnDeletePatientService.Text = "Избриши услуга";
            btnDeletePatientService.UseVisualStyleBackColor = false;
            btnDeletePatientService.Click += btnDeletePatientService_Click;
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 233);
            ClientSize = new Size(1302, 971);
            Controls.Add(panelNewService);
            Controls.Add(button2);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnAddService);
            Controls.Add(dgvServices);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(btnChangeInfo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(LabelName);
            Controls.Add(txtHomeAddress);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEMBG);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(cbServices);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimumSize = new Size(1200, 1018);
            Name = "PatientDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Детали за пациент";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            gbAddService.ResumeLayout(false);
            gbAddService.PerformLayout();
            panelNewService.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEMBG;
        private TextBox txtPhoneNumber;
        private TextBox txtEmailAddress;
        private TextBox txtHomeAddress;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label LabelName;
        private Button btnChangeInfo;
        private RichTextBox txtDescription;
        private Label label6;
        private DataGridView dgvServices;
        private Button btnAddService;
        private Button btnSaveChanges;
        private GroupBox gbAddService;
        private TextBox txtServiceName;
        private Button btnCloseAddService;
        private TextBox txtPricePayed;
        private TextBox txtPrice;
        private RichTextBox txtServiceDescription;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button1;
        private Label label10;
        private Button button2;
        private Panel panelNewService;
        private ComboBox cbServices;
        private Button btnDeletePatientService;
    }
}