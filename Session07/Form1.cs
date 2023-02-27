using Session07.UI;

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
    }
}