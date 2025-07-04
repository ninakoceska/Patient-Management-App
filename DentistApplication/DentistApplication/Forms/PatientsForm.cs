using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DentistApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DentistApplication.Forms
{

    public partial class PatientsForm : Form
    {
        BindingList<Patient> patients;
        public PatientsForm()
        {
            InitializeComponent();
            patients = new BindingList<Patient>();
            dgvPatients.DataSource = patients;
            AlterColumns();

        }
        

        private void AlterColumns()
        {
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Columns["FirstName"].HeaderText = "Име";
            dgvPatients.Columns["LastName"].HeaderText = "Презиме";
            dgvPatients.Columns["EMBG"].HeaderText = "ЕМБГ";
            dgvPatients.Columns["PhoneNumber"].HeaderText = "Телефон";
            dgvPatients.Columns["EmailAddress"].HeaderText = "Емаил";
            dgvPatients.Columns["HomeAddress"].HeaderText = "Адреса";
            dgvPatients.Columns["Description"].Visible = false;
            //dgvPatients.Columns["PatientServices"].Visible = false;
            dgvPatients.Columns["Id"].Visible = false;

        }

        public void LoadList()
        {
            
            patients.Clear();

                List<Patient> p = Program.Context.Patients.ToList();
                for (int i = p.Count() - 1; i >= 0; i--)
                {
                    patients.Add(p[i]);
                }
            
        }

        private void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPatients.SelectedRows[0];

            var patientId = selectedRow.Cells["Id"].Value.ToString();

            Guid id = Guid.Parse(patientId);

            Patient p = Program.Context.Patients
                .Include(x => x.PatientServices)
                .FirstOrDefault(x => x.Id == id);

            PatientDetailsForm patientDetailsForm = new PatientDetailsForm(p);
            patientDetailsForm.LoadPatientDetails(p);
            patientDetailsForm.Show();

            patientDetailsForm.UpdatePatientChanges = new Action(() =>
            {
                LoadList();
            });


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            var searchParts = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filtered = patients.Where(p => searchParts.All(term =>
            (p.FirstName != null && p.FirstName.ToLower().Contains(term)) ||
            (p.LastName != null && p.LastName.ToLower().Contains(term)) ||
            (p.EMBG != null && p.EMBG.ToLower().Contains(term))
        )).ToList();

            dgvPatients.DataSource = filtered;

        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (dgvPatients.RowCount>0)
            {
                DataGridViewRow selectedRow = dgvPatients.SelectedRows[0];
                Patient p = (Patient)selectedRow.DataBoundItem;

                Program.Context.Patients.Remove(p);
                Program.Context.SaveChanges();
                LoadList();
            }
            
        }
    }
}
