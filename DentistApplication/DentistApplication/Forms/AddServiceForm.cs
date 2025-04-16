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
            dgvServices.Enabled = true;
            btnAddNewService.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != "" && txtServicePrice.Text != "")
            {
                Program.Context.Services.Add(new Service
                {
                    ServiceName = txtServiceName.Text,
                    Price = int.Parse(txtServicePrice.Text)
                });
                Program.Context.SaveChanges();
                MessageBox.Show("Услугата е успешно додадена!");
                LoadList();
                gbNewService.Visible = false;
                txtServiceName.Text = "";
                txtServicePrice.Text = "";
                dgvServices.Enabled = true;
                btnAddNewService.Enabled = true;
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

    }
}
