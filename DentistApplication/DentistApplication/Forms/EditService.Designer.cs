namespace DentistApplication.Forms
{
    partial class EditService
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtServicePrice = new TextBox();
            txtServiceName = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(13, 73, 81);
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(255, 270);
            button1.Name = "button1";
            button1.Size = new Size(311, 48);
            button1.TabIndex = 10;
            button1.Text = "Зачувај Услуга";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(310, 164);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 9;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(310, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 8;
            label1.Text = "Име";
            // 
            // txtServicePrice
            // 
            txtServicePrice.Anchor = AnchorStyles.None;
            txtServicePrice.Location = new Point(310, 195);
            txtServicePrice.MinimumSize = new Size(200, 50);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(200, 50);
            txtServicePrice.TabIndex = 7;
            // 
            // txtServiceName
            // 
            txtServiceName.Anchor = AnchorStyles.None;
            txtServiceName.Location = new Point(310, 111);
            txtServiceName.MinimumSize = new Size(200, 50);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(200, 50);
            txtServiceName.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(255, 335);
            button2.Name = "button2";
            button2.Size = new Size(311, 48);
            button2.TabIndex = 11;
            button2.Text = "Избриши Услуга";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EditService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 233);
            ClientSize = new Size(818, 475);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtServicePrice);
            Controls.Add(txtServiceName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditService";
            Text = "Измени";
            FormClosing += EditService_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtServicePrice;
        private TextBox txtServiceName;
        private Button button2;
    }
}