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
        int ItemPerPage = 10;

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
            
            CreatePagination();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repository.Create(new Product { ProductName = "Sample" });
            MessageBox.Show("Done");
            LoadData();
        }

        private void LoadData(int page = 1)
        {
            //LINQ,
            //.Take(10),
            //.Skip(10).Take(10)

            //💀💀💀 NA BAYAD BAD AZ .list() bashan
            //dataGridView1.DataSource = repository.AsQueryable<Product>().ToList().Take(10);
            

            // 79 / 10 -> 7.9 

            var skip = (page - 1 ) * ItemPerPage;
            dataGridView1.DataSource = repository.AsQueryable<Product>().Skip(skip).Take(ItemPerPage).ToList();
        }

        private void CreatePagination()
        {
            var cnt = repository.AsQueryable<Product>().Count();

            // 79 / 10 -> 7.9
            int pageCnt = Convert.ToInt32(Math.Ceiling((double)cnt / ItemPerPage));

            for (int i = 1; i <= pageCnt; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Tag = i;
                btn.Location = new Point(i * btn.Width, 10);
                btn.Click += Btn_Click;
                panel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            var btn = (Button)sender;
            LoadData((int)btn.Tag);
        }

 
    }
}
