using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _4enLinea
{
    public partial class Menu_form : Form
    {
        SortedList<string, User> UserSortedList { get; set; }
        List<User> UserList { get; set; }

        public Menu_form()
        {
            UserSortedList = Import(); //reads data from file and sorts them
            UserList = SetList(); //reads data from file unsorted

            InitializeComponent();
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {

        }

        private void inst_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Instruction = new Insrt_form(this);
            Instruction.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form UsersForm = new UserData(this, UserList, UserSortedList);
            UsersForm.Show();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Players = new PlayerForm(this, UserList, UserSortedList);

            Players.Show();
        }
        private List<User> SetList()
        {
            List<User> list = new List<User>();
            if (File.Exists(@"C:\Users\Manuela\source\repos\4enLinea\PlayersData.txt")) //if the file exists
            {
                string[] lines = File.ReadAllLines(@"C:\Users\Manuela\source\repos\4enLinea\PlayersData.txt"); //read all lines of file
                string[] values;

                for (int i = 0; i < lines.Length; i++) //foreach diferent user
                {
                    User new_player = new User();
                    values = lines[i].ToString().Split(' ');

                    new_player.SetData(values);

                    list.Add(new_player); //add new player to list of players
                }

            }
            else
            {
                File.CreateText(@"C:\Users\Manuela\source\repos\4enLinea\PlayersData.txt");
            }
            return list;
        }

        SortedList<string, User> Import()
        {
            SortedList<string, User> list = new SortedList<string, User>();
            if (File.Exists(@"C:\Users\Manuela\source\repos\4enLinea\PlayersData.txt")) //if the file exists
            {
                string[] lines = File.ReadAllLines(@"C:\Users\Manuela\source\repos\4enLinea\PlayersData.txt"); //read all lines of file
                string[] values;

                for (int i = 0; i < lines.Length; i++) //foreach diferent user
                {
                    User new_player = new User();
                    values = lines[i].ToString().Split(' ');

                    new_player.SetData(values);

                    list.Add(values[2], new_player); //add new player to list of players
                }

            }
            else
            {
                File.CreateText(@"C:\Users\Manuela\source\repos\4enLinea\PlayersData.txt");
            }
            return list;
        }
    }
}
