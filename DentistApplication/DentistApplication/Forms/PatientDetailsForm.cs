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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentistApplication.Forms
{
    public partial class PatientDetailsForm : Form
    {
        private Patient patient;
        private BindingList<PatientService> patientServices;
        private List<Service> services;
        private bool flag;
        public Action UpdatePatientChanges;
        private string Desc;
        

        public PatientDetailsForm(Patient p)
        {
            InitializeComponent();
            flag = false;
            btnSaveChanges.Visible = false;
            patient = p;

            patientServices = new BindingList<PatientService>();
            services = new List<Service>();
            cbServices.DataSource = Program.Context.Services.ToList();

            dgvServices.DataSource = patientServices;

            #region dgvRegion

            dgvServices.Columns["Patient"].Visible = false;
            dgvServices.Columns["PatientId"].Visible = false;
            dgvServices.Columns["Euro"].Visible = false;
            dgvServices.Columns["ServiceName"].HeaderText = "Услуга";
            dgvServices.Columns["Date"].HeaderText = "Датум";
            dgvServices.Columns["ServiceDescription"].HeaderText = "Опис";
            dgvServices.Columns["Price"].HeaderText = "Цена";
            dgvServices.Columns["Quantity"].HeaderText = "Количина";
            dgvServices.Columns["PricePaid"].HeaderText = "Платено";
            dgvServices.Columns["IsEuroText"].HeaderText = "Валута";
            dgvServices.Columns["Done"].HeaderText = "Завршено";



            dgvServices.Columns["ServiceName"].ReadOnly = true;
            dgvServices.Columns["ServiceDescription"].ReadOnly = true;
            dgvServices.Columns["Price"].ReadOnly = true;
            dgvServices.Columns["PricePaid"].ReadOnly = true;
            //dgvServices.Columns["Done"].ReadOnly = true;
            dgvServices.Columns["Quantity"].ReadOnly = true;
            dgvServices.Columns["Date"].ReadOnly = true;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion

            LoadPatientServices();

            panelNewService.Visible = false;


        }

        public void CalculateTotalPrice()
        {
            int totalDen = 0;
            int totalEur = 0;
            if (patientServices.Count() != 0)
            {
                foreach (PatientService service in patientServices)
                {
                    if (service.PricePaid < service.Price)
                    {
                        if (service.Euro)
                        {
                            totalEur += Convert.ToInt32(service.Price);
                        }
                        else
                        {
                            totalDen += Convert.ToInt32(service.Price);
                        }
                    }
                }
                if (totalDen != 0 && totalEur != 0)
                {
                    lblTotalPrice.Text = "Вкупно: " + totalDen + "ден. и " + totalEur + "eur.";
                }
                else if (totalDen == 0 && totalEur != 0)
                {
                    lblTotalPrice.Text = "Вкупно: " + totalEur + "eur.";
                }
                else if (totalDen != 0 && totalEur == 0)
                {
                    lblTotalPrice.Text = "Вкупно: " + totalDen + "ден";
                }
                else
                {
                    lblTotalPrice.Text = "Вкупно: 0";
                }
            }
            else
            {
                lblTotalPrice.Text = "Вкупно: 0";
            }
        }

        public void LoadPatientServices()
        {
            patientServices.Clear();

            foreach (PatientService x in patient.PatientServices.OrderByDescending(s => s.Date).ToList())
            {
                patientServices.Add(x);
            }

            dgvServices.DataSource = patientServices;
            dgvServices.Columns["Id"].Visible = false;
            CalculateTotalPrice();

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

            Desc = txtDescription.Text;

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
            btnDeletePatientService.Visible = false;

        }

        private void btnCloseAddService_Click(object sender, EventArgs e)
        {
            panelNewService.Visible = false;
            chbIsEuro.Checked = false;
            txtServiceDescription.Text = "";
            txtServiceName.Text = "";
            txtPrice.Text = "";
            txtPricePayed.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                if (txtQuantity.Text == "" || txtQuantity.Text == "0" || txtServiceName.Text==""||txtPrice.Text=="")
                {
                    MessageBox.Show("Сите полиња мора да бидат пополнети!");
                }
                else
                {
                    if (int.TryParse(txtPrice.Text, out _)&& int.TryParse(txtPricePayed.Text, out _))
                    {
                        var service = new PatientService
                        {
                            ServiceName = txtServiceName.Text,
                            ServiceDescription = txtServiceDescription.Text,
                            Price = Int32.Parse(txtPrice.Text) * Int32.Parse(txtQuantity.Text),
                            PricePaid = Int32.Parse(txtPricePayed.Text),
                            Patient = patient,
                            Euro = chbIsEuro.Checked,
                            Quantity = Int32.Parse(txtQuantity.Text),
                            Date = DateTime.Now.Date,
                            Done = false,
                        };

                        if (Int32.Parse(txtPricePayed.Text) >= service.Price)
                        {
                            service.Done = true;
                        }
                        else
                        {
                            service.Done = false;
                        }

                        Program.Context.PatientServices.Add(service);
                        Program.Context.SaveChanges();
                        LoadPatientServices();
                        txtServiceDescription.Text = "";
                        txtServiceName.Text = "";
                        txtPrice.Text = "";
                        txtPricePayed.Text = "";
                        chbIsEuro.Checked = false;

                        panelNewService.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Цените мора да содржат само броеви!");
                    }
                    
                    
                }

            }

            if (flag == true)
            {

                if (txtQuantity.Text == "" || txtQuantity.Text == "0" || txtServiceName.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Сите полиња мора да бидат пополнети!");
                }
                else
                {
                    if (int.TryParse(txtPrice.Text, out _) && int.TryParse(txtPricePayed.Text, out _)) {
                        DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                        PatientService s = (PatientService)selectedRow.DataBoundItem;

                        s.ServiceName = txtServiceName.Text;
                        s.ServiceDescription = txtServiceDescription.Text;
                        s.Price = Int32.Parse(txtPrice.Text) * Int32.Parse(txtQuantity.Text);
                        s.PricePaid = Int32.Parse(txtPricePayed.Text);
                        s.Euro = chbIsEuro.Checked;
                        s.Quantity = Int32.Parse(txtQuantity.Text);
                        if ( Int32.Parse(txtPricePayed.Text) >= s.Price )
                        {
                            s.Done = true;
                        }
                        else
                        {
                            s.Done = false;
                        }
                            flag = false;

                        Program.Context.SaveChanges();
                        LoadPatientServices();
                        txtServiceDescription.Text = "";
                        txtServiceName.Text = "";
                        txtPrice.Text = "";
                        txtPricePayed.Text = "";
                        chbIsEuro.Checked = false;

                        panelNewService.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Цените мора да содржат само броеви!");
                    }
                        

                }

            }





        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelNewService.Visible = true;
            flag = true;
            btnDeletePatientService.Visible = true;

            DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
            PatientService s = (PatientService)selectedRow.DataBoundItem;

            txtServiceDescription.Text = s.ServiceDescription;
            txtServiceName.Text = s.ServiceName;
            txtQuantity.Text = s.Quantity.ToString();
            txtPricePayed.Text = s.PricePaid.ToString();
            txtPrice.Text = (s.Price / s.Quantity).ToString();
            chbIsEuro.Checked = s.Euro;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtServiceQuantity.Text == "" || txtServiceQuantity.Text == "0")
            {
                MessageBox.Show("Мора да внесите количина!");
            }
            else
            {
                Service s = (Service)cbServices.SelectedItem;

                Program.Context.PatientServices.Add(new PatientService
                {
                    Patient = patient,
                    ServiceName = s.ServiceName,
                    ServiceDescription = "",
                    Price = s.Price * Int32.Parse(txtServiceQuantity.Text),
                    Quantity = Int32.Parse(txtServiceQuantity.Text),
                    PricePaid = 0,
                    Date = DateTime.Now.Date,
                    Done = false,
                    Euro = s.Euro,
                });

                txtServiceQuantity.Text = "1";
                Program.Context.SaveChanges();
                LoadPatientServices();
            }
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



        private void PatientDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtDescription.Text != Desc)
            {
                patient.Description = txtDescription.Text;
                Program.Context.SaveChanges();
            }
        }

        private void btnPayAll_Click(object sender, EventArgs e)
        {
            foreach (PatientService s in patientServices)
            {
                if (s.PricePaid < s.Price)
                {
                    s.PricePaid = s.Price;
                    s.Done = true;
                }
            }
            Program.Context.SaveChanges();
            LoadPatientServices();
        }

        private void dgvServices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (patientServices.Count() != 0)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                PatientService s = (PatientService)selectedRow.DataBoundItem;

                if (s.Done)
                {
                    s.Done = false;
                    s.PricePaid = 0;
                }
                else
                {
                    s.Done = true;
                    s.PricePaid = s.Price;
                }
                Program.Context.SaveChanges();
                LoadPatientServices();
            }

        }

        private void dgvServices_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (patientServices.Count() != 0)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                PatientService s = (PatientService)selectedRow.DataBoundItem;

                if (s.Done)
                {
                    s.Done = false;
                    s.PricePaid = 0;
                }
                else
                {
                    s.Done = true;
                    s.PricePaid = s.Price;
                }
                Program.Context.SaveChanges();
                LoadPatientServices();
            }

        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            
            var searchWord = txtSearchService.Text;
            if(searchWord=="" || searchWord == null)
            {
                cbServices.DataSource = Program.Context.Services.ToList();
                cbServices.DroppedDown = false;
            }
            else
            {
                cbServices.DataSource = Program.Context.Services.Where(s => s.ServiceName.ToLower().StartsWith(searchWord.ToLower())).ToList();
                cbServices.DroppedDown = true;
            }


        }

        //private void PatientDetailsForm_Load(object sender, EventArgs e)
        //{
        //    cbServices.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    cbServices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


        //    data.AddRange(Program.Context.Services.Select(s => $"{s.ServiceName}").ToArray());


        //    cbServices.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    cbServices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    cbServices.AutoCompleteCustomSource = data;
        //    foreach (var service in Program.Context.Services)
        //    {
        //        foreach(AutoCompleteStringCollection a in data)
        //        {
        //            if (service.ServiceName.StartsWith(a))
        //            {
        //                filteredList.Add(service);
        //            }
        //        }
        //    }

        //}


    }
}
