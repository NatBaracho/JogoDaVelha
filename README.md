# 🎮 Jogo da Velha (Tic-Tac-Toe) - WinForms

Este é um projeto clássico de **Jogo da Velha** desenvolvido em **C#** utilizando a tecnologia **Windows Forms (WinForms)**. O jogo permite partidas locais entre dois jogadores, com controle automático de turnos e gerenciamento de placar.

---

## 🚀 Funcionalidades

* **Partida para 2 Jogadores:** Alternância automática entre os jogadores "X" e "O".
* **Placar Acumulativo:** Sistema que armazena a pontuação de vitórias de cada jogador durante a sessão.
* **Detecção de Vitória:** Verificação automática de linhas, colunas e diagonais.
* **Empate (Deu Velha):** Alerta visual quando o tabuleiro é preenchido sem um vencedor.
* **Reinício Rápido:** Botão para limpar o tabuleiro sem perder o placar atual.
* **Reset Total:** Opção para zerar as pontuações e reiniciar a competição.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET (Windows Forms)
* **IDE:** Visual Studio

---

## 💻 Estrutura do Código

A lógica do sistema foi construída de forma modular para facilitar a manutenção:

* **Controle de Estado:** Utiliza variáveis privadas como `_vezDoX` e `_jogadas` para gerenciar o fluxo do jogo.
* **Lógica de Verificação:** O método `VerificarVencedor` utiliza a função auxiliar `ChecarTrinca` para validar as 8 combinações possíveis de vitória.
* **Interface Reativa:** Os Labels de pontuação (`lblX`, `lblO`) e de turno (`lblVez`) são atualizados instantaneamente a cada ação.

---

## 🔧 Configuração do Ambiente

Para que o código funcione corretamente, os componentes no **Windows Forms Designer** devem possuir os seguintes nomes (Name):

| Componente | Nomes Sugeridos |
| :--- | :--- |
| **Botões do Grid** | `btn1`, `btn2`, `btn3`, `btn4`, `btn5`, `btn6`, `btn7`, `btn8`, `btn9` |
| **Labels de Placar** | `lblX`, `lblO` |
| **Label de Turno** | `lblVez` |
| **Botões de Ação** | `btnReiniciar`, `btnZeraPlacar` |

---

## 📝 Como rodar o projeto

1. Abra o **Visual Studio**.
2. Crie um novo projeto do tipo **Windows Forms App**.
3. Substitua o código do arquivo `Form1.cs` pelo código fornecido neste repositório.
4. Conecte os eventos de clique dos botões do grid ao método `BotaoGrid_Click`.
5. Compile e execute pressionando `F5`.

---
*Desenvolvido como exemplo de lógica de programação e interface gráfica em C#.*
