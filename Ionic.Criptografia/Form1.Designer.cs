namespace Ionic.Criptografia
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
            txtChave = new TextBox();
            txtMensagem = new TextBox();
            lblChave = new Label();
            lblMensagem = new Label();
            button1 = new Button();
            txtResultado = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtChave
            // 
            txtChave.Location = new Point(200, 47);
            txtChave.Name = "txtChave";
            txtChave.Size = new Size(242, 23);
            txtChave.TabIndex = 0;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(200, 87);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(242, 23);
            txtMensagem.TabIndex = 1;
            // 
            // lblChave
            // 
            lblChave.AutoSize = true;
            lblChave.Location = new Point(128, 50);
            lblChave.Name = "lblChave";
            lblChave.Size = new Size(40, 15);
            lblChave.TabIndex = 2;
            lblChave.Text = "Chave";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(128, 87);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(66, 15);
            lblMensagem.TabIndex = 3;
            lblMensagem.Text = "Mensagem";
            // 
            // button1
            // 
            button1.Location = new Point(200, 168);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 4;
            button1.Text = "Cripitografar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(200, 128);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(242, 23);
            txtResultado.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(128, 131);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(button1);
            Controls.Add(lblMensagem);
            Controls.Add(lblChave);
            Controls.Add(txtMensagem);
            Controls.Add(txtChave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChave;
        private TextBox txtMensagem;
        private Label lblChave;
        private Label lblMensagem;
        private Button button1;
        private TextBox txtResultado;
        private Label lblResultado;
    }
}