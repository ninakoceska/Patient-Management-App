using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentistApplication.Models;

namespace DentistApplication.Forms
{
    public partial class AddPatientForm : Form
    {
        BindingList<Patient> patients;
        public AddPatientForm()
        {
            InitializeComponent();

            patients = new BindingList<Patient>();
            
        }



        private void btnSavePatient_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text != "" && txtLastName.Text != "") { 

            Program.Context.Patients.Add(new Patient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                EmailAddress = txtEmailAddress.Text,
                EMBG = txtEMBG.Text,
                HomeAddress = txtHomeAddress.Text,
                Description = txtDescription.Text,
                PhoneNumber = txtPhoneNumber.Text,
             
            });
                txtEMBG.Text = "";
                txtFirstName.Text = "";
                txtHomeAddress.Text = "";
                txtLastName.Text = "";
                txtPhoneNumber.Text = "";
                txtEmailAddress.Text = "";
                txtDescription.Text = "";
                MessageBox.Show("Пациентот е успешно додаден!");
                Program.Context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Мора да внесите име и презиме!");
            }

        }
    }
}
