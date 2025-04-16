using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentistApplication.Models;

namespace DentistApplication.Forms
{
    public partial class PatientDetailsForm : Form
    {
        private Patient patient;
        private BindingList<PatientService> patientServices;
        private BindingList<Service> services;
        private bool flag;
        public Action UpdatePatientChanges;
        public PatientDetailsForm(Patient p)
        {
            InitializeComponent();
            flag = false;
            btnSaveChanges.Visible = false;
            patient = p;

            patientServices = new BindingList<PatientService>();
            services = new BindingList<Service>();
            cbServices.DataSource = Program.Context.Services.ToList();

            dgvServices.DataSource = patientServices;

            #region dgvRegion

            dgvServices.Columns["Patient"].Visible = false;
            dgvServices.Columns["PatientId"].Visible = false;
            dgvServices.Columns["ServiceName"].HeaderText = "Услуга";
            dgvServices.Columns["Date"].HeaderText = "Датум";
            dgvServices.Columns["ServiceDescription"].HeaderText = "Опис";
            dgvServices.Columns["Price"].HeaderText = "Цена";
            dgvServices.Columns["PricePaid"].HeaderText = "Платено";
            dgvServices.Columns["Done"].HeaderText = "Завршено";



            dgvServices.Columns["ServiceName"].ReadOnly = true;
            dgvServices.Columns["ServiceDescription"].ReadOnly = true;
            dgvServices.Columns["Price"].ReadOnly = true;
            dgvServices.Columns["PricePaid"].ReadOnly = true;
            dgvServices.Columns["Done"].ReadOnly = true;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion

            LoadPatientServices();
            panelNewService.Visible = false;

        }

        public void LoadPatientServices()
        {
            patientServices.Clear();
            foreach (PatientService x in patient.PatientServices.ToList())
            {
                patientServices.Add(x);
            }



            dgvServices.DataSource = patientServices;
            dgvServices.Columns["Id"].Visible = false;

        }

        public void LoadPatientDetails(Patient p)
        {
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtDescription.Text = p.Description;
            txtEMBG.Text = p.EMBG;
            txtPhoneNumber.Text = p.PhoneNumber;
            txtEmailAddress.Text = p.EmailAddress;
            txtHomeAddress.Text = p.HomeAddress;

            txtEmailAddress.Enabled = false;
            txtEMBG.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtHomeAddress.Enabled = false;
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            btnChangeInfo.Visible = false;
            btnSaveChanges.Visible = true;

            txtEmailAddress.Enabled = true;
            txtEMBG.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtHomeAddress.Enabled = true;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.HomeAddress = txtHomeAddress.Text;
            patient.EmailAddress = txtEmailAddress.Text;
            patient.EMBG = txtEMBG.Text;
            patient.PhoneNumber = txtPhoneNumber.Text;

            Program.Context.SaveChanges();

            txtEmailAddress.Enabled = false;
            txtEMBG.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtHomeAddress.Enabled = false;

            btnChangeInfo.Visible = true;
            btnSaveChanges.Visible = false;

            UpdatePatientChanges.Invoke();

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            panelNewService.Visible = true;

        }

        private void btnCloseAddService_Click(object sender, EventArgs e)
        {
            panelNewService.Visible = false;
            txtServiceDescription.Text = "";
            txtServiceName.Text = "";
            txtPrice.Text = "";
            txtPricePayed.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {

                var service = new PatientService
                {
                    ServiceName = txtServiceName.Text,
                    ServiceDescription = txtServiceDescription.Text,
                    Price = Int32.Parse(txtPrice.Text),
                    PricePaid = Int32.Parse(txtPricePayed.Text),
                    Patient = patient,
                    Date = DateTime.Now.Date,
                    Done = false,
                };

                if (txtPrice.Text == txtPricePayed.Text)
                {
                    service.Done = true;
                }

                Program.Context.PatientServices.Add(service);

            }

            if (flag == true)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                PatientService s = (PatientService)selectedRow.DataBoundItem;

                s.ServiceName = txtServiceName.Text;
                s.ServiceDescription = txtServiceDescription.Text;
                s.Price = Int32.Parse(txtPrice.Text);
                s.PricePaid = Int32.Parse(txtPricePayed.Text);
                s.Patient = patient;
                if (txtPrice.Text == txtPricePayed.Text)
                {
                    s.Done = true;
                }
                flag = false;

            }


            Program.Context.SaveChanges();
            LoadPatientServices();
            txtServiceDescription.Text = "";
            txtServiceName.Text = "";
            txtPrice.Text = "";
            txtPricePayed.Text = "";

            panelNewService.Visible = false;


        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelNewService.Visible = true;
            flag = true;

            DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
            PatientService s = (PatientService)selectedRow.DataBoundItem;

            txtServiceDescription.Text = s.ServiceDescription;
            txtServiceName.Text = s.ServiceName;
            txtPrice.Text = s.Price.ToString();
            txtPricePayed.Text = s.PricePaid.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service s = (Service)cbServices.SelectedItem;

            Program.Context.PatientServices.Add(new PatientService
            {
                Patient = patient,
                ServiceName = s.ServiceName,
                ServiceDescription = "",
                Price = s.Price,
                PricePaid = 0,
                Date = DateTime.Now.Date,
                Done = false,
            });

            Program.Context.SaveChanges();
            LoadPatientServices();

        }

        private void btnDeletePatientService_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
            PatientService s = (PatientService)selectedRow.DataBoundItem;

            Program.Context.PatientServices.Remove(s);
            Program.Context.SaveChanges();
            LoadPatientServices();
            txtServiceDescription.Text = "";
            txtServiceName.Text = "";
            txtPrice.Text = "";
            txtPricePayed.Text = "";
            panelNewService.Visible = false;
            

        }
    }
}
