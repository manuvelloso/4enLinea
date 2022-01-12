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
    public partial class PlayerForm : Form
    {
        Form main_parent;

        Point point_username_login = new Point(269, 206);
        Point point_password_login = new Point(269, 246);

        Point point_txt_u_login = new Point(387, 201);
        Point point_txt_p_login = new Point(387, 246);

        Point point_password_sigin = new Point(269, 294);
        Point point_txt_p_signin = new Point(387, 289);

        Point point_ing_btn = new Point(429, 365);

        List<User> UserList { get; set; }
        SortedList<string, User> UserSortedList { get; set; }
        public List<User> Players; //TODO: se pasa al form del tablero

        uint num_players = 1; //TODO: se pasa al form del tablero
        int cont = 0; //counter of players
        public PlayerForm(Form main, List<User> list, SortedList<string, User> slist)
        {
            main_parent = main;

            UserList = list;
            UserSortedList = slist;

            InitializeComponent();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            lb_player.Visible = false;
            lb_two.Visible = false;
            lb_one.Visible = false;

            lb_name.Visible = false;
            lb_password.Visible = false;
            lb_surname.Visible = false;
            lb_username.Visible = false;

            txt_name.Visible = false;
            txt_password.Visible = false;
            txt_surname.Visible = false;
            txt_username.Visible = false;

            nxt_btn.Visible = false;

            login_btn.Visible = false;
            signin_btn.Visible = false;

            one_player_btn.Visible = true;
            two_player_btn.Visible = true;
            back_btn.Visible = true;

            save_btn.Visible = false;
            back_btn_registration.Visible = false;
            ing_btn.Visible = false;

            pbx_btns.Visible = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            main_parent.Show();
        }

        private void one_player_btn_Click(object sender, EventArgs e)
        {
            ChangePropertiesNumPlayers();
            num_players = 1;
            cont = 1;
            RegistrationMenu(true);
            Players = new List<User>(1);
            PlayerOne();
        }

        private void two_player_btn_Click(object sender, EventArgs e)
        {
            ChangePropertiesNumPlayers();
            num_players = 2;
            cont = 2; //counter of players

            RegistrationMenu(true);
            Players = new List<User>(2);
            PlayerTwo();
        }
        /// <summary>
        /// recive true en el caso de querer mostrar los botones de ingresar / registrarse
        /// </summary>
        /// <param name="var"></param>
        void RegistrationMenu(bool var)
        {
            login_btn.Visible = var;
            signin_btn.Visible = var;
            back_btn.Visible = var;
            pbx_btns.Visible = var;

        }
        /// <summary>
        /// recibe true en el caso de que se quiera registrar
        /// </summary>
        /// <param name="var"></param>
        void SignInMenu(bool var)
        {
            lb_player.Visible = true;
            

            lb_name.Visible = var;
            lb_password.Visible = var;
            lb_surname.Visible = var;
            lb_username.Visible = var;

            txt_name.Visible = var;
            txt_password.Visible = var;
            txt_surname.Visible = var;
            txt_username.Visible = var;

            save_btn.Visible = var;
            back_btn_registration.Visible = var;

            pbx_btns.Visible = false;
            back_btn.Visible = false;

            back_btn_registration.Visible = true;
            back_btn_registration.Enabled = true;

            save_btn.Visible = true;
            save_btn.Enabled = true;

            lb_surname.Location = point_username_login;
            lb_username.Location = point_password_login;
            lb_password.Location = point_password_sigin;

            txt_password.Location = point_txt_p_signin;
            txt_surname.Location = point_txt_u_login;
            txt_username.Location = point_txt_p_login;

            if (cont == 2)
                PlayerTwo();
            else if (cont == 1)
                PlayerOne();
        }
        void LogInMenu(bool var)
        {
            lb_password.Visible = var;
            lb_username.Visible = var;

            txt_password.Visible = var;
            txt_username.Visible = var;

            ing_btn.Visible = var;

            lb_name.Visible = false;
            lb_surname.Visible = false;

            txt_name.Visible = false;
            txt_surname.Visible = false;

            back_btn.Visible = false;
            ing_btn.Enabled = true;

            pbx_btns.Visible = false;

            lb_username.Location = point_username_login;
            lb_password.Location = point_password_login;

            txt_username.Location = point_txt_u_login;
            txt_password.Location = point_txt_p_login;

            ing_btn.Location = point_ing_btn;
            back_btn_registration.Visible = true;
            back_btn_registration.Enabled = true;

            if (cont == 2)
                PlayerTwo();
            else if (cont == 1)
                PlayerOne();
        }

        void ChangePropertiesNumPlayers()
        {
            //this.BackgroundImage = Image.FromFile("background.png");
            
            back_btn.Visible = true;
            one_player_btn.Visible = false;
            two_player_btn.Visible = false;
        }
        void ChangePropertiesRegistration()
        {
            //this.BackgroundImage = Image.FromFile("background.png");

            back_btn.Visible = true;
            login_btn.Visible = false;
            signin_btn.Visible = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            ChangePropertiesRegistration();

            LogInMenu(true);
        }
        
        /// <summary>
        /// recibe true en el caso de quere mostrar los ocntroles de ingresar
        /// </summary>
        /// <param name="var"></param>
       
        private void signin_btn_Click(object sender, EventArgs e)
        {
            ChangePropertiesRegistration();
            SignInMenu(true);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            User player = new User();

            if (txt_surname.TextLength == 0 || txt_name.TextLength == 0 || txt_username.TextLength == 0 || txt_password.TextLength == 0) //data missing
                MessageBox.Show("Alguno de los campos esta vacío.\nPor favor complete todos los campos.");
            else
            {
                //saving writen data
                player.name = txt_name.Text;
                player.surname = txt_surname.Text;

                player.username = txt_username.Text;
                player.password = txt_password.Text;

                if (UserSortedList.ContainsKey(player.username)) //if the username is already taken
                {
                    MessageBox.Show("El nombre de usuario escrito ya existe.\nPor favor ingrese otro.");
                    txt_username.Text = "";
                }
                else
                {
                    UserList.Add(player); //add player to list of players
                    UserSortedList.Add(player.username, player);
                    Players.Add(player);
                }

                cont--; //the player was added

                //the user can't change the data once is added to the list
                txt_name.Enabled = false;
                txt_username.Enabled = false;
                txt_surname.Enabled = false;
                txt_password.Enabled = false;

                if (cont > 0) //if there are 2 players
                {
                    save_btn.Enabled = false;
                    back_btn_registration.Enabled = false;
                    nxt_btn.Visible = true;
                }
                else //there is only one player
                {
                    //TODO: aca se cierra este form y se habre el del tablero
                    this.Hide();

                }
            }
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            SignInMenu(false);
            LogInMenu(false);
            RegistrationMenu(true);

            txt_name.Enabled = true;
            txt_username.Enabled = true;
            txt_surname.Enabled = true;
            txt_password.Enabled = true;

            txt_username.Text = "";
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_password.Text = "";

            login_btn.Visible = true;
            signin_btn.Visible = true;
            back_btn.Visible = true;

            nxt_btn.Visible = false;
            back_btn_registration.Visible = false;
            save_btn.Visible = false;

            PlayerOne();
        }

        private void ing_btn_Click(object sender, EventArgs e)
        {
            User player;

            if (UserSortedList.ContainsKey(txt_username.Text)) //if the username exist
            {
                int index = UserSortedList.IndexOfKey(txt_username.Text); //index were the username is found

               player = UserSortedList.ElementAt(index).Value; //player at that index
                if (txt_password.Text != player.password) //passwords must match
                    MessageBox.Show("Contraseña incorrecta.\nPor favor vuelva a intentarlo.");
                else
                {
                    Players.Add(player); //add player to list
                    cont--;

                    if (cont > 0)
                    {
                        ing_btn.Enabled = false;
                        back_btn_registration.Enabled = false;
                        nxt_btn.Visible = true;
                    }
                    else
                    {
                        //TODO: aca se cierra este form y se habre el del tablero
                        this.Hide();
                    }
                }
            }
            else
                MessageBox.Show("Nombre de usuario incorrecto.\nPor favor vuelva a intentarlo."); //user not found
        }

        private void back_btn_registration_Click(object sender, EventArgs e)
        {
            SignInMenu(false);
            LogInMenu(false);

            RegistrationMenu(true);

            back_btn_registration.Visible = false;
            ing_btn.Visible = false;
            save_btn.Visible = false;
            nxt_btn.Visible = false;
        }

        private void PlayerTwo()
        {
            lb_player.Visible = true;
            lb_two.Visible = true;
            lb_one.Visible = false;
        }

        private void PlayerOne()
        {
            lb_player.Visible = true;
            lb_two.Visible = false;
            lb_one.Visible = true;
        }

    }
}
