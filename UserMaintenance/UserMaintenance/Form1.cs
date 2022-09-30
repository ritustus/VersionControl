using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            label_LastName.Text = Resource1.LastName;
            label_FirstName.Text = Resource1.FirstName;
            button_Add.Text = Resource1.Add;
            button_Delete.Text = Resource1.Delete;

            list_User.DataSource = users;
            list_User.ValueMember = "ID";
            list_User.DisplayMember = "FullName";

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = text_LastName.Text,
                FirstName = text_FirstName.Text

            };
            users.Add(u);
              
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            
            User user = (User)list_User.SelectedItem;

            users.Remove(user);
 
        }

       
    }
}
