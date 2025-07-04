using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Forms;
using DentistApplication.Models;
using GemBox.Document;
using Word = Microsoft.Office.Interop.Word;

namespace DentistApplication.Forms
{
    public partial class CreateOfferForm : Form
    {
        BindingList<Service> services;
        BindingList<Service> dgvList;

        public CreateOfferForm()
        {
            InitializeComponent();
            services = new BindingList<Service>();
            dgvList = new BindingList<Service>();
            cbServices.DataSource = Program.Context.Services.ToList();
            dgvServices.DataSource = dgvList;
            dgvServices.Columns["Id"].Visible = false;
            dgvServices.Columns["Euro"].Visible = false;
            dgvServices.Columns["Quantity"].HeaderText = "Количина";
            dgvServices.Columns["ServiceName"].HeaderText = "Име";
            dgvServices.Columns["Price"].HeaderText = "Цена";
            dgvServices.Columns["IsEuroText"].HeaderText = "Валута";
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");


        }




        private void button1_Click(object sender, EventArgs e)
        {
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Invoice.docx");
            var document = DocumentModel.Load(templatePath);

            StringBuilder sb = new StringBuilder();
            var totalEur = 0;
            var totalDen = 0;
            sb.AppendLine("Услуга       Количина        Цена        Вкупна цена         Валута");
            foreach (Service s in dgvList)
            {
                sb.AppendLine(s.ServiceName + "       " + s.Quantity + "     " + "     " + s.Price + "      " + s.Quantity * s.Price + "      " + s.IsEuroText);
                if (s.Euro)
                {
                    totalEur += s.Price * s.Quantity;
                }
                else
                {
                    totalDen += s.Price * s.Quantity;
                }

            }
            var total = totalEur + "eur и " + totalDen + "ден";
            document.Content.Replace("<<ServiceTable>>", sb.ToString());
            document.Content.Replace("<<TotalPrice>>", total.ToString());

            var outputPath = Path.Combine(Application.StartupPath, "ExportInvoice.pdf");
            document.Save(outputPath, new PdfSaveOptions());

            MessageBox.Show("PDF saved to: " + outputPath);
            System.Diagnostics.Process.Start("explorer.exe", outputPath);


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || txtQuantity.Text == "0")
            {
                MessageBox.Show("Мора да внесите количина!");
            }
            else
            {
                Service s = (Service)cbServices.SelectedItem;
                Service newService = new Service
                {
                    ServiceName = s.ServiceName,
                    Price = s.Price,
                    Quantity = Int32.Parse(txtQuantity.Text),
                    Euro = s.Euro,
                };
                dgvList.Add(newService);


                labelPrice.Text = GetPrice();

                txtQuantity.Text = "1";


            }

        }

        private string GetPrice()
        {
            int priceEuro = 0;
            int priceDenar = 0;

            foreach (Service s in dgvList)
            {
                if (s.Euro)
                {
                    priceEuro += s.Price * s.Quantity;
                }
                else
                {
                    priceDenar += s.Price * s.Quantity;
                }


            }

            return $"{priceEuro}eur и {priceDenar}ден";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchWord = txtSearchService.Text;
            if (searchWord == "" || searchWord == null)
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
    }
}
