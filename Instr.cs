using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4enLinea
{
    public partial class Insrt_form : Form
    {
        Form main_parent;
        public Insrt_form(Form main)
        {
            main_parent = main;
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            main_parent.Show();
        }
    }
}
