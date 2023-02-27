using Session07.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session07.UI
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        Repository repository= new Repository();

        private void FormProducts_Load(object sender, EventArgs e)
        {
            //using (var ctx = new NorthWindContext())
            //{
            //    dataGridView1.DataSource = ctx.Products.ToList();
            //}

            
            dataGridView1.DataSource = repository.AsQueryable<Product>().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repository.Create(new Product { ProductName = "Sample" });
            MessageBox.Show("Done");
            dataGridView1.DataSource = repository.AsQueryable<Product>().ToList();
        }
    }
}
