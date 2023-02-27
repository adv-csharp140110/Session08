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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //Validation
            //Policy

            var repo = new Repository();
            if(repo.AsQueryable<User>().Any(x => x.Username == textBoxUsername.Text))
            {
                MessageBox.Show("username exists!");
                return;
            }
            if(textBoxPassword.Text != textBoxPassword2.Text)
            {
                MessageBox.Show("passwords not maching!");
                return;
            }

            //hash -> md5, sha128, sha256, ...
            //ramz negari -> 1tarafe
            // 123456 -> md5 -> 564654635sdfg;lksdhgjk
            //loing  123456 -> md5 -> 564654635sdfg;lksdhgjk


            string hash = (textBoxPassword.Text).ToSHA512();
            repo.Create(new User { Username = textBoxUsername.Text, Password = hash });
            MessageBox.Show("Register done!");
        }
    }
}
