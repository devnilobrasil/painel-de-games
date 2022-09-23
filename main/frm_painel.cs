using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainelGames_nbr
{
    public partial class frm_painel : Form
    {
        public frm_painel()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_jdv_menu_Click(object sender, EventArgs e)
        {
            panel_side_menu.Height = btn_jdv_menu.Height;
            jogo_da_velha1.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_side_menu.Height = btn_home.Height;
            panel_content.BringToFront();
        }

    }
}
