namespace DentistApplication.Forms
{
    partial class PatientsForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvPatients = new DataGridView();
            txtSearch = new TextBox();
            btnDeletePatient = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AllowUserToResizeColumns = false;
            dgvPatients.AllowUserToResizeRows = false;
            dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = Color.FromArgb(243, 240, 233);
            dgvPatients.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(114, 148, 148);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(114, 148, 148);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.Location = new Point(2, 83);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.ScrollBars = ScrollBars.Vertical;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(797, 368);
            dgvPatients.TabIndex = 1;
            dgvPatients.CellDoubleClick += dgvPatients_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(126, 24);
            txtSearch.MaxLength = 0;
            txtSearch.MinimumSize = new Size(550, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(550, 40);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletePatient.BackColor = Color.Maroon;
            btnDeletePatient.Font = new Font("Segoe UI", 10F);
            btnDeletePatient.ForeColor = Color.White;
            btnDeletePatient.Location = new Point(636, 417);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(163, 34);
            btnDeletePatient.TabIndex = 11;
            btnDeletePatient.Text = "Избриши пациент";
            btnDeletePatient.UseVisualStyleBackColor = false;
            btnDeletePatient.Click += btnDeletePatient_Click;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 233);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletePatient);
            Controls.Add(txtSearch);
            Controls.Add(dgvPatients);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientsForm";
            Text = "PatientsForm";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPatients;
        private TextBox txtSearch;
        private Button btnDeletePatient;
    }
}