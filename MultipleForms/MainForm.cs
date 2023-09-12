using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class MainForm : Form
    {
        private BindingList<PersonModel> _personList = new BindingList<PersonModel>();

        public MainForm()
        {
            InitializeComponent();

            listBox1.DataSource = _personList;
            listBox1.DisplayMember = nameof(Name);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
