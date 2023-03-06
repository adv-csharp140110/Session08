﻿using Session07.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session07.UI
{
    public partial class FormPermission : Form
    {
        Repository repository = new Repository();
        List<String> checkedButtons= new List<String>();

        public FormPermission()
        {
            InitializeComponent();
        }

        private void FormPermission_Load(object sender, EventArgs e)
        {
            comboBoxRoles.DisplayMember = "Name";
            comboBoxRoles.ValueMember = "Id";
            comboBoxRoles.DataSource = repository.AsQueryable<Role>().ToList();

            //Reflection
            var assembly = Assembly.GetExecutingAssembly();
            //linq
            var forms = assembly.GetTypes().Where(t => t.BaseType == typeof(Form));
            foreach (var form in forms)
            {
                listBoxForms.Items.Add(form.FullName);
            }



        }

        private void listBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxButtons.Items.Clear();
            var fromName = listBoxForms.SelectedItem as string;
            var formType = Type.GetType(fromName);
            var frm = Activator.CreateInstance(formType) as Form;
            // new Form1

            //var buttons = formType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance)
            //    .Where(t => t.GetType() == typeof(Button));


            foreach (var ctrl in frm.Controls)
            {
                if(ctrl is Button)
                {
                    var button = (Button)ctrl;
                    string key = $"{fromName}|{button.Name}";
                    checkedListBoxButtons.Items.Add(key, checkedButtons.Contains(key));
                }
            }
            frm.Dispose();

        }

        private void checkedListBoxButtons_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void checkedListBoxButtons_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string key = checkedListBoxButtons.SelectedItem as string;
            if(e.NewValue == CheckState.Checked && !checkedButtons.Contains(key))
            {
                checkedButtons.Add(key);
            }

            if (e.NewValue == CheckState.Unchecked && checkedButtons.Contains(key))
            {
                checkedButtons.Remove(key);
            }
        }
    }
}
