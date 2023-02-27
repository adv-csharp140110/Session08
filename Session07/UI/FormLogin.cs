using Session07.Models;
using Session07.utils;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var repo = new Repository();
            var user = repo.AsQueryable<User>().FirstOrDefault(x => x.Username == textBoxUsername.Text);
            if (user == null)
            {
                MessageBox.Show("نام کاربری یا گزرواژه اشتباه است");
                return;
            }
            string hash = (textBoxPassword.Text + user.Salt).ToSHA512();
            if(hash != user.Password)
            {
                MessageBox.Show("نام کاربری یا گزرواژه اشتباه است");
                return;
            }
            MessageBox.Show("Login success");
            Close();
        }
    }
}
