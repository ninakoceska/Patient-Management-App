namespace DentistApplication.Forms
{
    partial class AddPatientForm
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
            txtLastName = new TextBox();
            txtEMBG = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtHomeAddress = new TextBox();
            txtFirstName = new TextBox();
            txtDescription = new RichTextBox();
            LabelDescription = new Label();
            LabelName = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSavePatient = new Button();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtLastName.Font = new Font("Segoe UI", 13F);
            txtLastName.ForeColor = Color.FromArgb(13, 73, 81);
            txtLastName.Location = new Point(103, 197);
            txtLastName.MinimumSize = new Size(242, 50);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(242, 50);
            txtLastName.TabIndex = 1;
            // 
            // txtEMBG
            // 
            txtEMBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEMBG.Font = new Font("Segoe UI", 13F);
            txtEMBG.ForeColor = Color.FromArgb(13, 73, 81);
            txtEMBG.Location = new Point(103, 294);
            txtEMBG.MaximumSize = new Size(300, 100);
            txtEMBG.MinimumSize = new Size(242, 50);
            txtEMBG.Name = "txtEMBG";
            txtEMBG.Size = new Size(242, 50);
            txtEMBG.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPhoneNumber.Font = new Font("Segoe UI", 13F);
            txtPhoneNumber.ForeColor = Color.FromArgb(13, 73, 81);
            txtPhoneNumber.Location = new Point(103, 395);
            txtPhoneNumber.MinimumSize = new Size(242, 50);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(242, 50);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEmailAddress.Font = new Font("Segoe UI", 13F);
            txtEmailAddress.ForeColor = Color.FromArgb(13, 73, 81);
            txtEmailAddress.Location = new Point(103, 493);
            txtEmailAddress.MinimumSize = new Size(242, 50);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(242, 50);
            txtEmailAddress.TabIndex = 4;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtHomeAddress.Font = new Font("Segoe UI", 13F);
            txtHomeAddress.ForeColor = Color.FromArgb(13, 73, 81);
            txtHomeAddress.Location = new Point(103, 594);
            txtHomeAddress.MinimumSize = new Size(242, 50);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(242, 50);
            txtHomeAddress.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtFirstName.Font = new Font("Segoe UI", 13F);
            txtFirstName.ForeColor = Color.FromArgb(13, 73, 81);
            txtFirstName.Location = new Point(103, 100);
            txtFirstName.MinimumSize = new Size(242, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(242, 50);
            txtFirstName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDescription.Font = new Font("Segoe UI", 13F);
            txtDescription.Location = new Point(597, 100);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(411, 490);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // LabelDescription
            // 
            LabelDescription.Anchor = AnchorStyles.Top;
            LabelDescription.AutoSize = true;
            LabelDescription.Font = new Font("Segoe UI", 15F);
            LabelDescription.ForeColor = Color.FromArgb(13, 73, 81);
            LabelDescription.Location = new Point(597, 62);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(75, 35);
            LabelDescription.TabIndex = 8;
            LabelDescription.Text = "Опис";
            // 
            // LabelName
            // 
            LabelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 15F);
            LabelName.ForeColor = Color.FromArgb(13, 73, 81);
            LabelName.Location = new Point(103, 62);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(65, 35);
            LabelName.TabIndex = 9;
            LabelName.Text = "Име";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(13, 73, 81);
            label2.Location = new Point(103, 159);
            label2.Name = "label2";
            label2.Size = new Size(118, 35);
            label2.TabIndex = 10;
            label2.Text = "Презиме";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(13, 73, 81);
            label1.Location = new Point(103, 256);
            label1.Name = "label1";
            label1.Size = new Size(76, 35);
            label1.TabIndex = 11;
            label1.Text = "ЕМБГ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(13, 73, 81);
            label3.Location = new Point(103, 357);
            label3.Name = "label3";
            label3.Size = new Size(113, 35);
            label3.TabIndex = 12;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(13, 73, 81);
            label4.Location = new Point(104, 455);
            label4.Name = "label4";
            label4.Size = new Size(87, 35);
            label4.TabIndex = 13;
            label4.Text = "Емаил";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.FromArgb(13, 73, 81);
            label5.Location = new Point(104, 556);
            label5.Name = "label5";
            label5.Size = new Size(98, 35);
            label5.TabIndex = 14;
            label5.Text = "Адреса";
            // 
            // btnSavePatient
            // 
            btnSavePatient.Anchor = AnchorStyles.Top;
            btnSavePatient.BackColor = Color.FromArgb(13, 73, 81);
            btnSavePatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePatient.ForeColor = SystemColors.Control;
            btnSavePatient.Location = new Point(122, 707);
            btnSavePatient.Name = "btnSavePatient";
            btnSavePatient.Size = new Size(208, 73);
            btnSavePatient.TabIndex = 15;
            btnSavePatient.Text = "Зачувај";
            btnSavePatient.UseVisualStyleBackColor = false;
            btnSavePatient.Click += btnSavePatient_Click;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 233);
            ClientSize = new Size(1090, 801);
            Controls.Add(btnSavePatient);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(LabelName);
            Controls.Add(LabelDescription);
            Controls.Add(txtDescription);
            Controls.Add(txtHomeAddress);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEMBG);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPatientForm";
            Text = "AddPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLastName;
        private TextBox txtEMBG;
        private TextBox txtPhoneNumber;
        private TextBox txtEmailAddress;
        private TextBox txtHomeAddress;
        private TextBox txtFirstName;
        private RichTextBox txtDescription;
        private Label LabelDescription;
        private Label LabelName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSavePatient;
    }
}