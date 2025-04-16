using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistApplication.Forms
{
    public partial class Home : Form
    {
        private PatientsForm _patientsForm;
        private AddPatientForm _addPatientForm;
        private AddServiceForm _addServiceForm;
        public Home()
        {
            InitializeComponent();
            Program.Context = new ApplicationDbContext();

            _patientsForm = new PatientsForm();
            _addPatientForm = new AddPatientForm();
            _addServiceForm = new AddServiceForm();

            InitializeFormInPanel(_patientsForm, tabPage2);
            InitializeFormInPanel(_addPatientForm, tabPage3);
            InitializeFormInPanel(_addServiceForm, tabPage4);

        }

        private void Home_Shown(object sender, EventArgs e)
        {
            _patientsForm.Show();
            _addPatientForm.Show();
            _addServiceForm.Show();
        }

        static void InitializeFormInPanel(Form f, TabPage t)
        {
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            t.Controls.Add(f);

        }

        

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl.TabPages[e.Index];
            Color selectedTabColor = Color.FromArgb(128, 156, 156);
            Color unselectedTabColor = Color.FromArgb(13, 73, 81);

            Color tabColor = e.Index == tabControl.SelectedIndex ? selectedTabColor : unselectedTabColor;

            using (SolidBrush brush = new SolidBrush(tabColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            using (Brush textBrush = new SolidBrush(Color.White))
            {
                string tabText = tabPage.Text;
                SizeF textSize = e.Graphics.MeasureString(tabText, e.Font);
                float textX = e.Bounds.X + (e.Bounds.Width - textSize.Width) / 2;
                float textY = e.Bounds.Y + (e.Bounds.Height - textSize.Height) / 2;
                e.Graphics.DrawString(tabText, e.Font, textBrush, textX, textY);
            }

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == tabPage2)
            {
                _patientsForm.LoadList();
            }
            //if(tabControl.SelectedTab == tabPage4)
            //{
            //    _addServiceForm
            //}
        }
    }
}
