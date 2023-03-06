using Microsoft.EntityFrameworkCore;
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
            var user = repo.AsQueryable<User>()
                .Include(x => x.Role)
                .Include(x => x.Role.PermissionRoles)
                .FirstOrDefault(x => x.Username == textBoxUsername.Text);
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
            AppData.User = user;
            AppData.Permissions = repo.AsQueryable<Permission>().ToList();
            Hide();
            var frm = new Form1();
            frm.ShowDialog();
            Close();
        }
    }
}
