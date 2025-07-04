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

    public partial class AddServiceForm : Form
    {
        BindingList<Service> services;
        public AddServiceForm()
        {
            InitializeComponent();

            services = new BindingList<Service>();
            dgvServices.DataSource = services;
            LoadList();
            gbNewService.Visible = false;
            dgvServices.Columns["Id"].Visible = false;
            dgvServices.Columns["ServiceName"].HeaderText = "Име";
            dgvServices.Columns["Price"].HeaderText = "Цена";
            dgvServices.Columns["IsEuroText"].HeaderText = "Валута";
            dgvServices.Columns["Quantity"].Visible = false;
            dgvServices.Columns["Euro"].Visible = false;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void LoadList()
        {
            services.Clear();


            foreach (Service x in Program.Context.Services)
            {
                services.Add(x);
            }

        }

        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            gbNewService.Visible = true;
            dgvServices.Enabled = false;
            btnAddNewService.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbNewService.Visible = false;
            txtServiceName.Text = "";
            txtServicePrice.Text = "";
            chbEuro.Checked = false;
            dgvServices.Enabled = true;
            btnAddNewService.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != "" && txtServicePrice.Text != "")
            {
                if (int.TryParse(txtServicePrice.Text, out _))
                {
                    Program.Context.Services.Add(new Service
                    {
                        ServiceName = txtServiceName.Text,
                        Price = int.Parse(txtServicePrice.Text),
                        Quantity = 1,
                        Euro = chbEuro.Checked
                    });
                    Program.Context.SaveChanges();
                    MessageBox.Show("Услугата е успешно додадена!");
                    LoadList();
                    gbNewService.Visible = false;
                    txtServiceName.Text = "";
                    txtServicePrice.Text = "";
                    chbEuro.Checked = false;
                    dgvServices.Enabled = true;
                    btnAddNewService.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Цената мора да содржи само броеви!");
                }
            }
            else
            {
                MessageBox.Show("Мора да внесите име и цена!");
            }
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
            Service s = (Service)selectedRow.DataBoundItem;
            EditService _editServiveForm = new EditService(s);
            _editServiveForm.Show();
            this.Enabled = false;

            _editServiveForm.LoadServiceForm = new Action(() =>
            {
                this.Enabled = true;
                LoadList();
            });

        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            CreateOfferForm _createOfferForm = new CreateOfferForm();
         
            _createOfferForm.Show();
        }
    }
}
