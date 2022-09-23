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
    public partial class jogo_da_velha : UserControl
    {
        int contagemX;
        int contagemO;
        int PlacarX = 0;
        int PlacarY = 0;
        bool validar = false;
        int Draw;

        bool TurnoPlayer1 = true; //  TurnoPlayer1 = true -> 'X' joga; TurnoPlayer1 = false -> 'O' joga;

        public void Placar()
        {
            if (validar == true && contagemX > contagemO) // Descreve o número de partidas ganhas na label respectiva;
            {
                lbl_resultado_j1.Text = Convert.ToString(PlacarX += 1);
                validar = false;

            } else if (validar == true & contagemO > contagemX)
            {
                lbl_resultado_j2.Text = Convert.ToString(PlacarY += 1);
                validar = false;
            }

            if (lbl_resultado_j1.Text == Convert.ToString(5)) // O Jogador que alcançar 5 vitórias vence o jogo;
            {
                MessageBox.Show("PLAYER 1 VENCEU O JOGO!", "PARABÉNS!!");
                Reiniciar();
            } else if (lbl_resultado_j2.Text == Convert.ToString(5))
            {
                MessageBox.Show("PLAYER 2 VENCEU O JOGO!", "PARABÉNS!!");
                Reiniciar();
            }
        }
        public void ValidarVitoria()
        {

            // Linhas
            if (btn_n1.Text == btn_n2.Text && btn_n1.Text == btn_n3.Text && btn_n1.Text != "") // Linha 1;
            {
                validar = true;
                EfeitoVencedor(btn_n1, btn_n2, btn_n3);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();

            } else if (btn_n4.Text == btn_n5.Text && btn_n4.Text == btn_n6.Text && btn_n4.Text != "") // Linha 2
            {
                validar = true;
                EfeitoVencedor(btn_n4, btn_n5, btn_n6);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();

            } else if (btn_n7.Text == btn_n8.Text && btn_n8.Text == btn_n9.Text && btn_n7.Text != "") // Linha 3
            {
                validar = true;
                EfeitoVencedor(btn_n7, btn_n8, btn_n9);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();

                // Colunas
            } else if (btn_n1.Text == btn_n4.Text && btn_n4.Text == btn_n7.Text && btn_n1.Text != "") // Coluna 1
            {
                validar = true;
                EfeitoVencedor(btn_n1, btn_n4, btn_n7);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();
            } else if (btn_n2.Text == btn_n5.Text && btn_n5.Text == btn_n8.Text && btn_n2.Text != "") // Coluna 2
            {
                validar = true;
                EfeitoVencedor(btn_n2, btn_n5, btn_n8);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();
            } else if (btn_n3.Text == btn_n6.Text && btn_n6.Text == btn_n9.Text && btn_n3.Text != "") // Coluna 3
            {
                validar = true;
                EfeitoVencedor(btn_n3, btn_n6, btn_n9);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();

                //Diagonal
            } else if (btn_n1.Text == btn_n5.Text && btn_n5.Text == btn_n9.Text && btn_n1.Text != "") // Diagonal 1
            {
                validar = true;
                EfeitoVencedor(btn_n1, btn_n5, btn_n9);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();
            } else if (btn_n3.Text == btn_n5.Text && btn_n5.Text == btn_n7.Text && btn_n3.Text != "") // Diagonal 2
            {
                validar = true;
                EfeitoVencedor(btn_n3, btn_n5, btn_n7);
                MessageBox.Show("VÔCÊ VENCEU!", "PARABÉNS!!");
                Draw = 0;
                Zerar();

            } else if (Draw == 9 && validar == false) // Verifica o EMPATE (DRAW) caso não haja combinações vencedoras;
            {
                MessageBox.Show("EMPATE!! JOGUE NOVAMENTE!", "EMPATE!");
                Draw = 0;
                Zerar();
            }
        }

        public void EfeitoVencedor(Button b1, Button b2, Button b3) // Pinta o fundo e o texto de cada botão vencedor;
        {
            b1.BackColor = Color.Black;
            b2.BackColor = Color.Black;
            b3.BackColor = Color.Black;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;
        }

        public void Zerar() // Reinicia o jogo sem zerar o placar; 
        {
            btn_n1.Text = "";
            btn_n1.BackColor = Color.White;
            btn_n1.ForeColor = DefaultForeColor;

            btn_n2.Text = "";
            btn_n2.BackColor = Color.White;
            btn_n2.ForeColor = DefaultForeColor;

            btn_n3.Text = "";
            btn_n3.BackColor = Color.White;
            btn_n3.ForeColor = DefaultForeColor;

            btn_n4.Text = "";
            btn_n4.BackColor = Color.White;
            btn_n4.ForeColor = DefaultForeColor;

            btn_n5.Text = "";
            btn_n5.BackColor = Color.White;
            btn_n5.ForeColor = DefaultForeColor;

            btn_n6.Text = "";
            btn_n6.BackColor = Color.White;
            btn_n6.ForeColor = DefaultForeColor;

            btn_n7.Text = "";
            btn_n7.BackColor = Color.White;
            btn_n7.ForeColor = DefaultForeColor;

            btn_n8.Text = "";
            btn_n8.BackColor = Color.White;
            btn_n8.ForeColor = DefaultForeColor;

            btn_n9.Text = "";
            btn_n9.BackColor = Color.White;
            btn_n9.ForeColor = DefaultForeColor;

            contagemX = 0;
            contagemO = 0;
            Draw = 0;

        }
        public void Reiniciar() // Reinicia o jogo por completo; 
        {
            btn_n1.Text = "";
            btn_n1.BackColor = Color.White;
            btn_n1.ForeColor = DefaultForeColor;

            btn_n2.Text = "";
            btn_n2.BackColor = Color.White;
            btn_n2.ForeColor = DefaultForeColor;

            btn_n3.Text = "";
            btn_n3.BackColor = Color.White;
            btn_n3.ForeColor = DefaultForeColor;

            btn_n4.Text = "";
            btn_n4.BackColor = Color.White;
            btn_n4.ForeColor = DefaultForeColor;

            btn_n5.Text = "";
            btn_n5.BackColor = Color.White;
            btn_n5.ForeColor = DefaultForeColor;

            btn_n6.Text = "";
            btn_n6.BackColor = Color.White;
            btn_n6.ForeColor = DefaultForeColor;

            btn_n7.Text = "";
            btn_n7.BackColor = Color.White;
            btn_n7.ForeColor = DefaultForeColor;

            btn_n8.Text = "";
            btn_n8.BackColor = Color.White;
            btn_n8.ForeColor = DefaultForeColor;

            btn_n9.Text = "";
            btn_n9.BackColor = Color.White;
            btn_n9.ForeColor = DefaultForeColor;

            lbl_resultado_j1.Text = "";
            lbl_resultado_j2.Text = "";

            contagemX = 0;
            contagemO = 0;

            PlacarX = 0;
            PlacarY = 0;

            Draw = 0;

        }


        public jogo_da_velha()
        {
            InitializeComponent();
        }

        private void btn_game_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                Draw++;
                if (TurnoPlayer1 == true)
                {
                    btn.Text = "X";
                    TurnoPlayer1 = false;
                    ValidarVitoria();
                    contagemX++;
                    Placar();

                } else
                {
                    btn.Text = "O";
                    TurnoPlayer1 = true;
                    ValidarVitoria();
                    contagemO++;
                    Placar();
                }

            }
        }

        private void btn_new_game_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void btn_restart_game_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
    }
}
