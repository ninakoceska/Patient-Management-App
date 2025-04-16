namespace DentistApplication.Forms
{
    partial class Home
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Dock = DockStyle.Fill;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(350, 60);
            tabControl.Location = new Point(0, 0);
            tabControl.MinimumSize = new Size(280, 60);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 5);
            tabControl.RightToLeft = RightToLeft.No;
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(978, 599);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 1;
            tabControl.DrawItem += tabControl_DrawItem;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.Logo_01;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 64);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(970, 531);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Почетна";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(243, 240, 233);
            tabPage2.ForeColor = SystemColors.ActiveCaption;
            tabPage2.Location = new Point(4, 64);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(970, 531);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пациенти";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(243, 240, 233);
            tabPage3.Location = new Point(4, 64);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(970, 531);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Додај Пациент";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(243, 240, 233);
            tabPage4.Location = new Point(4, 64);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(970, 531);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Услуги";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 73, 81);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 599);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Shown += Home_Shown;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}