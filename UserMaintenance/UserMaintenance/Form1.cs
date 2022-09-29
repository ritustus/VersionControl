using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            label_LastName.Text = Resource1.FullName;
            //label_FirstName.Text = Resource1.FirstName;
            button_Add.Text = Resource1.Add;
            button_File.Text = Resource1.File;

            list_User.DataSource = users;
            list_User.ValueMember = "ID";
            list_User.DisplayMember = "FullName";

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = text_LastName.Text,
               // FirstName = text_FirstName.Text

            };
            users.Add(u);
              
        }

        private void button_File_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.AddExtension = true;
            sfd.Filter = "szöveg (*.csv) | *.csv";
            sfd.DefaultExt = "csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                foreach (var u in users)
                {
                    sw.WriteLine($"{u.FullName};{u.ID}");
                }
                sw.Close();
            }
        }
    }
}
