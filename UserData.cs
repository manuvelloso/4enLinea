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
    public partial class UserData : Form
    {
        Form main_parent;
        SortedList<string, User> UserSortedList { get; set; }
        List<User> UserList { get; set; }
        
        public UserData(Form main, List<User> list, SortedList<string, User> slist)
        {
            main_parent = main;

            UserList = list;
            UserSortedList = slist;

            InitializeComponent();
        }

        

        private void UserData_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = UserList;

            //not visible areas
            user_dtg.Columns["name"].Visible = false;
            user_dtg.Columns["surname"].Visible = false;
            user_dtg.Columns["password"].Visible = false;
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            main_parent.Show();
        }

        //write file


        //display players

    }
}

