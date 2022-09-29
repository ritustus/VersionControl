using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_LastName.Text = Resource1.LastName;
            label_FirstName.Text = Resource1.FirstName;
            button_Add.Text = Resource1.Add;

        }
    }
}
