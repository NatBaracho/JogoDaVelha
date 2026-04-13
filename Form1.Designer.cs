namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblReiniciar = new Button();
            lblVez = new Label();
            label1 = new Label();
            label3 = new Label();
            lblX = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn1.Location = new Point(29, 90);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += BotaoGrid_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn2.Location = new Point(115, 90);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += BotaoGrid_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn3.Location = new Point(201, 90);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += BotaoGrid_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn4.Location = new Point(29, 176);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += BotaoGrid_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn5.Location = new Point(115, 176);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += BotaoGrid_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn6.Location = new Point(201, 176);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += BotaoGrid_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn7.Location = new Point(29, 262);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += BotaoGrid_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn8.Location = new Point(115, 262);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += BotaoGrid_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn9.Location = new Point(201, 262);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += BotaoGrid_Click;
            // 
            // lblReiniciar
            // 
            lblReiniciar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReiniciar.Location = new Point(29, 348);
            lblReiniciar.Name = "lblReiniciar";
            lblReiniciar.Size = new Size(252, 53);
            lblReiniciar.TabIndex = 9;
            lblReiniciar.Text = "REINICIAR O JOGO";
            lblReiniciar.UseVisualStyleBackColor = true;
            lblReiniciar.Click += btnReiniciar_Click;
            // 
            // lblVez
            // 
            lblVez.AutoSize = true;
            lblVez.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVez.Location = new Point(68, 45);
            lblVez.Name = "lblVez";
            lblVez.Size = new Size(172, 25);
            lblVez.TabIndex = 10;
            lblVez.Text = "vez do Jogador: X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(411, 70);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 11;
            label1.Text = "Placar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 126);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 14;
            label3.Text = "Vs";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(354, 166);
            lblX.Name = "lblX";
            lblX.Size = new Size(34, 15);
            lblX.TabIndex = 15;
            lblX.Text = "X = 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 569);
            Controls.Add(lblX);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblVez);
            Controls.Add(lblReiniciar);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button lblReiniciar;
        private Label lblVez;
        private Label label1;
        private Label label3;
        private Label lblX;
    }
}
