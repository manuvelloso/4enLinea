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
    public partial class JuegoForm : Form
    {
        Form main_parent;
        List<User> Players;
        public JuegoForm(Form main, List<User> users)
        {
            main_parent = main;
            Players = users;
            InitializeComponent();
        }

        private void JuegoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
