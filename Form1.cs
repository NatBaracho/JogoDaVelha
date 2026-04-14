using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        // Variáveis de controle do jogo
        private bool _vezDoX = true;
        private int _jogadas = 0;

        // Variáveis do placar (ELAS PRECISAM ESTAR AQUI)
        private int _pontosX = 0;
        private int _pontosO = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoGrid_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            // Bloqueia clique em botão já preenchido
            if (botaoClicado.Text != "") return;

            // Define a jogada
            botaoClicado.Text = _vezDoX ? "X" : "O";
            _jogadas++;

            // 1. Verifica se houve vencedor
            if (VerificarVencedor())
            {
                string vencedor = _vezDoX ? "X" : "O";

                // Atualiza as variáveis de pontos e os Labels
                if (_vezDoX)
                {
                    _pontosX++;
                    lblX.Text = $"X = {_pontosX}";
                }
                else
                {
                    _pontosO++;
                    lblO.Text = $"{_pontosO} = O";
                }

                MessageBox.Show($"Fim de jogo! O jogador {vencedor} venceu!", "Temos um Vencedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ZerarTabuleiro();
            }
            // 2. Verifica se deu empate
            else if (_jogadas == 9)
            {
                MessageBox.Show("Deu Velha! O jogo empatou.", "Empate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ZerarTabuleiro();
            }
            // 3. Continua o jogo (passa a vez)
            else
            {
                _vezDoX = !_vezDoX;
                lblVez.Text = $"Vez do Jogador: {(_vezDoX ? "X" : "O")}";
            }
        }

        private bool VerificarVencedor()
        {
            // Linhas
            if (ChecarTrinca(btn1, btn2, btn3)) return true;
            if (ChecarTrinca(btn4, btn5, btn6)) return true;
            if (ChecarTrinca(btn7, btn8, btn9)) return true;
            // Colunas
            if (ChecarTrinca(btn1, btn4, btn7)) return true;
            if (ChecarTrinca(btn2, btn5, btn8)) return true;
            if (ChecarTrinca(btn3, btn6, btn9)) return true;
            // Diagonais
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
            // Limpa o texto de todos os botões
            btn1.Text = btn2.Text = btn3.Text = "";
            btn4.Text = btn5.Text = btn6.Text = "";
            btn7.Text = btn8.Text = btn9.Text = "";

            _vezDoX = true;
            _jogadas = 0;
            lblVez.Text = "Vez do Jogador: X";
        }

        private void btnZeraPlacar_Click(object sender, EventArgs e)
        {
            // Reseta as variáveis
            _pontosX = 0;
            _pontosO = 0;

            // Atualiza os Labels com o formato do seu designer
            lblX.Text = "X = 0";
            lblO.Text = "0 = O";

            ZerarTabuleiro();
        }

        // Métodos de eventos vazios para evitar erros se estiverem vinculados no Designer
        private void lblX_Click(object sender, EventArgs e) { }
        private void lblO_Click(object sender, EventArgs e) { }
    }
}