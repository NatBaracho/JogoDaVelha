using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaVelha
{
    // A classe do formulário (a janela do seu jogo)
    public partial class Form1 : Form
    {
        // --- VARIÁREIS DE CONTROLE (O "CÉREBRO" DO JOGO) ---

        // Esta variável guarda de quem é a vez. 
        // Se for 'true', é a vez do X. Se for 'false', é a vez do O.
        private bool _vezDoX = true;

        // Este número aumenta a cada clique. 
        // Como o jogo da velha só tem 9 espaços, se chegar a 9 e ninguém venceu, sabemos que empatou.
        private int _jogadas = 0;

        // --- VARIÁREIS DO PLACAR ---
        // Guardam a quantidade de vitórias de cada jogador.
        private int _pontosX = 0;
        private int _pontosO = 0;

        public Form1()
        {
            // Este método é padrão do C#. Ele "desenha" os botões e labels que você colocou no Designer.
            InitializeComponent();
        }

        // Este método é chamado toda vez que qualquer botão do tabuleiro for clicado.
        private void BotaoGrid_Click(object sender, EventArgs e)
        {
            // O 'sender' representa o botão que foi clicado. 
            // Nós o transformamos (convertemos) em um objeto do tipo Button para podermos mudar o texto dele.
            Button botaoClicado = (Button)sender;

            // REGRA DE SEGURANÇA: Se o botão já tiver um "X" ou "O", não faz nada e sai do método (return).
            if (botaoClicado.Text != "") return;

            // Se for a vez do X, escreve "X". Se não, escreve "O".
            // O símbolo '?' é um atalho para (se _vezDoX for verdade ? use "X" : senão use "O")
            botaoClicado.Text = _vezDoX ? "X" : "O";

            // Adiciona +1 ao contador de jogadas.
            _jogadas++;

            // 1. VERIFICAÇÃO DE VITÓRIA
            // Chamamos a função 'VerificarVencedor' para ver se alguém ganhou após esse clique.
            if (VerificarVencedor())
            {
                // Descobre quem ganhou para mostrar na mensagem.
                string vencedor = _vezDoX ? "X" : "O";

                // Atualiza os pontos e os textos (Labels) na tela.
                if (_vezDoX)
                {
                    _pontosX++; // Soma 1 ponto para X
                    lblX.Text = $"X = {_pontosX}"; // Atualiza o texto do placar do X
                }
                else
                {
                    _pontosO++; // Soma 1 ponto para O
                    lblO.Text = $"{_pontosO} = O"; // Atualiza o texto do placar do O
                }

                // Abre uma janelinha avisando quem venceu.
                MessageBox.Show($"Fim de jogo! O jogador {vencedor} venceu!", "Temos um Vencedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa o tabuleiro para começar outra partida.
                ZerarTabuleiro();
            }
            // 2. VERIFICAÇÃO DE EMPATE
            // Se chegou a 9 jogadas e o código não entrou no 'if' de cima, é porque ninguém ganhou.
            else if (_jogadas == 9)
            {
                MessageBox.Show("Deu Velha! O jogo empatou.", "Empate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ZerarTabuleiro();
            }
            // 3. CONTINUAÇÃO DO JOGO
            // Se não houve vitória nem empate, passamos a vez para o próximo jogador.
            else
            {
                // Inverte o valor de _vezDoX (se era true vira false, se era false vira true).
                _vezDoX = !_vezDoX;

                // Atualiza o texto que avisa de quem é a vez.
                lblVez.Text = $"Vez do Jogador: {(_vezDoX ? "X" : "O")}";
            }
        }

        // Função que checa todas as 8 combinações que dão vitória (3 horizontais, 3 verticais e 2 diagonais).
        private bool VerificarVencedor()
        {
            // Checa as LINHAS
            if (ChecarTrinca(btn1, btn2, btn3)) return true;
            if (ChecarTrinca(btn4, btn5, btn6)) return true;
            if (ChecarTrinca(btn7, btn8, btn9)) return true;

            // Checa as COLUNAS
            if (ChecarTrinca(btn1, btn4, btn7)) return true;
            if (ChecarTrinca(btn2, btn5, btn8)) return true;
            if (ChecarTrinca(btn3, btn6, btn9)) return true;

            // Checa as DIAGONAIS
            if (ChecarTrinca(btn1, btn5, btn9)) return true;
            if (ChecarTrinca(btn3, btn5, btn7)) return true;

            // Se o código chegou aqui e não retornou 'true', é porque ninguém completou uma trinca ainda.
            return false;
        }

        // Uma função auxiliar que recebe 3 botões e verifica se o texto deles é igual.
        private bool ChecarTrinca(Button b1, Button b2, Button b3)
        {
            // Primeiro: se o primeiro botão estiver vazio, não há trinca.
            if (b1.Text == "") return false;

            // Segundo: Verifica se o texto do botão 1 é igual ao 2, e se o 2 é igual ao 3.
            return (b1.Text == b2.Text && b2.Text == b3.Text);
        }

        // Evento do botão "Reiniciar" que apenas limpa o tabuleiro.
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ZerarTabuleiro();
        }

        // Método que limpa todos os botões e reseta as variáveis de controle.
        private void ZerarTabuleiro()
        {
            // Apaga o texto de todos os botões (deixa vazio).
            btn1.Text = btn2.Text = btn3.Text = "";
            btn4.Text = btn5.Text = btn6.Text = "";
            btn7.Text = btn8.Text = btn9.Text = "";

            _vezDoX = true;   // Reinicia sempre com o jogador X.
            _jogadas = 0;     // Zera o contador de jogadas.
            lblVez.Text = "Vez do Jogador: X";
        }

        // Evento para zerar totalmente os pontos e limpar a tela.
        private void btnZeraPlacar_Click(object sender, EventArgs e)
        {
            _pontosX = 0;
            _pontosO = 0;

            lblX.Text = "X = 0";
            lblO.Text = "0 = O";

            ZerarTabuleiro();
        }

        // Estes métodos abaixo são criados pelo Visual Studio se você clicar sem querer nos Labels.
        // Eles ficam vazios para não dar erro no código.
        private void lblX_Click(object sender, EventArgs e) { }
        private void lblO_Click(object sender, EventArgs e) { }
    }
}