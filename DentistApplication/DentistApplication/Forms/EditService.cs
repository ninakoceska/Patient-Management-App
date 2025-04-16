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
    public partial class EditService : Form
    {
        Service service;
        public Action LoadServiceForm;
        public EditService(Service s)
        {
            InitializeComponent();
            service = s;
            txtServiceName.Text = service.ServiceName;
            txtServicePrice.Text = service.Price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Program.Context.Services.Remove(service);
            Program.Context.SaveChanges();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != "" && txtServicePrice.Text != "")
            {
                service.ServiceName = txtServiceName.Text;
                service.Price = int.Parse(txtServicePrice.Text);
                Program.Context.SaveChanges();
                LoadServiceForm.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Мора да внесите име и цена!");
            }
        }

        private void EditService_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadServiceForm.Invoke();
        }
    }
}
