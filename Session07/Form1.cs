using Session07.Models;
using Session07.UI;
using System.Reflection;

namespace Session07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProductList_Click(object sender, EventArgs e)
        {
            var f = new FormProducts();
            f.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ToString(new Product { ProductId = 2, ProductName = "Mobile" }));
            MessageBox.Show(ToString(new Order { OrderId = 1 }));
        }


        private string ToString(object obj)
        {
            //Reflection
            // Run-time

            /*
             * ProductId:2,ProductName:Mobile,....
             * OrderId:1, ...
             */
            var result = "";
            var type = obj.GetType();
            var props  = type.GetProperties();
            foreach ( var prop in props )
            {
                result += $"{prop.Name}:{prop.GetValue(obj)},";
            }
            
            return result ;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var frm = new FormRegister();
            frm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.ShowDialog();
        }
    }
}