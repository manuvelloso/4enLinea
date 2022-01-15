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
        int turn;
        public JuegoForm(Form main, List<User> users)
        {
            main_parent = main;
            Players = users;
            InitializeComponent();
        }

        private void JuegoForm_Load(object sender, EventArgs e)
        {
            PrintTable();
            turn = Players.Count;
            txt_turn.Text = "Jugador "+ Players[turn - 1].username + " elija una posición.";
            
        }
        
        void PrintTable()
        {
            dtg_tbl.ColumnCount = 8; //TODO: poner constantes en globales
            dtg_tbl.RowCount = 8;
            
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    DataGridViewImageCell iCell = new DataGridViewImageCell();                               
                    iCell.Value = (Bitmap)Image.FromFile("sin_pieza.png");

                    dtg_tbl[i, j] = iCell;
                }
            }
        }

        private void btn_endgame_Click(object sender, EventArgs e)
        {

            this.Close();
            main_parent.Show();

        }

        void Position()
        {

        }

        private void dtg_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        void ChangeImage()
        {
            if (turn == 1)
                dtg_tbl.CurrentCell.Value = (Bitmap)Image.FromFile("con_pieza_roja.png");
            else if (turn == 2)
                dtg_tbl.CurrentCell.Value = (Bitmap)Image.FromFile("con_pieza_azul.png");
            else
                dtg_tbl.CurrentCell.Value = (Bitmap)Image.FromFile("sin_pieza.png");
        }
    }
}
