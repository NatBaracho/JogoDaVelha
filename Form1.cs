using System;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        // Variável para controlar de quem é a vez. true = X, false = O.
        private bool _vezDoX = true;
        // Contador para saber se deu empate (chegou a 9 jogadas e ninguém ganhou)
        private int _jogadas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoGrid_Click(object sender, EventArgs e)
        {
            // O "sender" é quem disparou o clique. Convertendo ele, sabemos exatamente em qual botão o usuário clicou.
            Button botaoClicado = (Button)sender;

            // Se o botão já tiver texto (já foi jogado), não faz nada (ignora o clique)
            if (botaoClicado.Text != "") return;

            // Se for a vez do X, escreve "X", senão, escreve "O"
            botaoClicado.Text = _vezDoX ? "X" : "O";
            _jogadas++;

            // Verifica se essa jogada fez alguém ganhar
            if (VerificarVencedor())
            {
                string vencedor = _vezDoX ? "X" : "O";
                MessageBox.Show($"Fim de jogo! O jogador {vencedor} venceu!", "Temos um Vencedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ZerarTabuleiro();
            }
            else if (_jogadas == 9) // Se ninguém ganhou e já foram 9 jogadas, então deu velha!
            {
                MessageBox.Show("Deu Velha! O jogo empatou.", "Empate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ZerarTabuleiro();
            }
            else
            {
                // Se ninguém ganhou e ainda tem espaço, passa a vez para o outro
                _vezDoX = !_vezDoX;
                lblVez.Text = $"Vez do Jogador: {(_vezDoX ? "X" : "O")}";
            }
        }

        private bool VerificarVencedor()
        {
            // Verificação das 3 Linhas horizontais
            if (ChecarTrinca(btn1, btn2, btn3)) return true;
            if (ChecarTrinca(btn4, btn5, btn6)) return true;
            if (ChecarTrinca(btn7, btn8, btn9)) return true;

            // Verificação das 3 Colunas verticais
            if (ChecarTrinca(btn1, btn4, btn7)) return true;
            if (ChecarTrinca(btn2, btn5, btn8)) return true;
            if (ChecarTrinca(btn3, btn6, btn9)) return true;

            // Verificação das 2 Diagonais
            if (ChecarTrinca(btn1, btn5, btn9)) return true;
            if (ChecarTrinca(btn3, btn5, btn7)) return true;

            return false;
        }

        private bool ChecarTrinca(Button b1, Button b2, Button b3)
        {
            if (b1.Text == "") return false;
            return (b1.Text == b2.Text && b2.Text == b3.Text);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ZerarTabuleiro();
        }

        private void ZerarTabuleiro()
        {
            btn1.Text = ""; btn2.Text = ""; btn3.Text = "";
            btn4.Text = ""; btn5.Text = ""; btn6.Text = "";
            btn7.Text = ""; btn8.Text = ""; btn9.Text = "";

            _vezDoX = true;
            _jogadas = 0;
            lblVez.Text = "Vez do Jogador: X";
        }

        
    }
}
