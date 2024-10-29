namespace novacalculadora
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
            txtResultado = new TextBox();
            buttZero = new Button();
            butum = new Button();
            butDois = new Button();
            butTres = new Button();
            butQuatro = new Button();
            butCinco = new Button();
            butSeis = new Button();
            butSete = new Button();
            butOito = new Button();
            butNove = new Button();
            butVirgu = new Button();
            butResult = new Button();
            butDiv = new Button();
            butMultpl = new Button();
            butSoma = new Button();
            butSubtr = new Button();
            butApagar = new Button();
            Calculadora = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(33, 33);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(259, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // buttZero
            // 
            buttZero.Location = new Point(100, 296);
            buttZero.Name = "buttZero";
            buttZero.Size = new Size(61, 57);
            buttZero.TabIndex = 1;
            buttZero.Text = "0";
            buttZero.UseVisualStyleBackColor = true;
            buttZero.Click += buttZero_Click;
            // 
            // butum
            // 
            butum.Location = new Point(33, 233);
            butum.Name = "butum";
            butum.Size = new Size(61, 57);
            butum.TabIndex = 2;
            butum.Text = "1";
            butum.UseVisualStyleBackColor = true;
            butum.Click += butum_Click;
            // 
            // butDois
            // 
            butDois.Location = new Point(100, 233);
            butDois.Name = "butDois";
            butDois.Size = new Size(61, 57);
            butDois.TabIndex = 3;
            butDois.Text = "2";
            butDois.UseVisualStyleBackColor = true;
            butDois.Click += butDois_Click;
            // 
            // butTres
            // 
            butTres.Location = new Point(167, 233);
            butTres.Name = "butTres";
            butTres.Size = new Size(61, 57);
            butTres.TabIndex = 4;
            butTres.Text = "3";
            butTres.UseVisualStyleBackColor = true;
            butTres.Click += butTres_Click;
            // 
            // butQuatro
            // 
            butQuatro.Location = new Point(33, 170);
            butQuatro.Name = "butQuatro";
            butQuatro.Size = new Size(61, 57);
            butQuatro.TabIndex = 5;
            butQuatro.Text = "4";
            butQuatro.UseVisualStyleBackColor = true;
            butQuatro.Click += butQuatro_Click;
            // 
            // butCinco
            // 
            butCinco.Location = new Point(100, 170);
            butCinco.Name = "butCinco";
            butCinco.Size = new Size(61, 57);
            butCinco.TabIndex = 6;
            butCinco.Text = "5";
            butCinco.UseVisualStyleBackColor = true;
            butCinco.Click += butCinco_Click;
            // 
            // butSeis
            // 
            butSeis.Location = new Point(167, 170);
            butSeis.Name = "butSeis";
            butSeis.Size = new Size(61, 57);
            butSeis.TabIndex = 7;
            butSeis.Text = "6";
            butSeis.UseVisualStyleBackColor = true;
            butSeis.Click += butSeis_Click;
            // 
            // butSete
            // 
            butSete.Location = new Point(36, 107);
            butSete.Name = "butSete";
            butSete.Size = new Size(61, 57);
            butSete.TabIndex = 8;
            butSete.Text = "7";
            butSete.UseVisualStyleBackColor = true;
            butSete.Click += butSete_Click;
            // 
            // butOito
            // 
            butOito.Location = new Point(100, 107);
            butOito.Name = "butOito";
            butOito.Size = new Size(61, 57);
            butOito.TabIndex = 9;
            butOito.Text = "8";
            butOito.UseVisualStyleBackColor = true;
            butOito.Click += butOito_Click;
            // 
            // butNove
            // 
            butNove.Location = new Point(167, 107);
            butNove.Name = "butNove";
            butNove.Size = new Size(61, 57);
            butNove.TabIndex = 10;
            butNove.Text = "9";
            butNove.UseVisualStyleBackColor = true;
            butNove.Click += butNove_Click;
            // 
            // butVirgu
            // 
            butVirgu.Location = new Point(32, 296);
            butVirgu.Name = "butVirgu";
            butVirgu.Size = new Size(61, 57);
            butVirgu.TabIndex = 11;
            butVirgu.Text = ",";
            butVirgu.UseVisualStyleBackColor = true;
            butVirgu.Click += butVirgu_Click;
            // 
            // butResult
            // 
            butResult.Location = new Point(167, 296);
            butResult.Name = "butResult";
            butResult.Size = new Size(61, 57);
            butResult.TabIndex = 12;
            butResult.Text = "=";
            butResult.UseVisualStyleBackColor = true;
            butResult.Click += butResult_Click;
            // 
            // butDiv
            // 
            butDiv.Location = new Point(234, 107);
            butDiv.Name = "butDiv";
            butDiv.Size = new Size(61, 57);
            butDiv.TabIndex = 13;
            butDiv.Text = "/";
            butDiv.UseVisualStyleBackColor = true;
            butDiv.Click += butDiv_Click;
            // 
            // butMultpl
            // 
            butMultpl.Location = new Point(234, 170);
            butMultpl.Name = "butMultpl";
            butMultpl.Size = new Size(61, 57);
            butMultpl.TabIndex = 14;
            butMultpl.Text = "*";
            butMultpl.UseVisualStyleBackColor = true;
            butMultpl.Click += butMultpl_Click;
            // 
            // butSoma
            // 
            butSoma.Location = new Point(234, 233);
            butSoma.Name = "butSoma";
            butSoma.Size = new Size(61, 57);
            butSoma.TabIndex = 15;
            butSoma.Text = "+";
            butSoma.UseVisualStyleBackColor = true;
            butSoma.Click += butSoma_Click;
            // 
            // butSubtr
            // 
            butSubtr.Location = new Point(234, 296);
            butSubtr.Name = "butSubtr";
            butSubtr.Size = new Size(61, 57);
            butSubtr.TabIndex = 16;
            butSubtr.Text = "-";
            butSubtr.UseVisualStyleBackColor = true;
            butSubtr.Click += butSubtr_Click;
            // 
            // butApagar
            // 
            butApagar.Location = new Point(234, 64);
            butApagar.Name = "butApagar";
            butApagar.Size = new Size(61, 37);
            butApagar.TabIndex = 17;
            butApagar.Text = "C";
            butApagar.UseVisualStyleBackColor = true;
            butApagar.Click += butApagar_Click;
            // 
            // Calculadora
            // 
            Calculadora.AutoSize = true;
            Calculadora.Location = new Point(36, 41);
            Calculadora.Name = "Calculadora";
            Calculadora.Size = new Size(0, 15);
            Calculadora.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(323, 450);
            Controls.Add(label1);
            Controls.Add(Calculadora);
            Controls.Add(butApagar);
            Controls.Add(butSubtr);
            Controls.Add(butSoma);
            Controls.Add(butMultpl);
            Controls.Add(butDiv);
            Controls.Add(butResult);
            Controls.Add(butVirgu);
            Controls.Add(butNove);
            Controls.Add(butOito);
            Controls.Add(butSete);
            Controls.Add(butSeis);
            Controls.Add(butCinco);
            Controls.Add(butQuatro);
            Controls.Add(butTres);
            Controls.Add(butDois);
            Controls.Add(butum);
            Controls.Add(buttZero);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button buttZero;
        private Button butum;
        private Button butDois;
        private Button butTres;
        private Button butQuatro;
        private Button butCinco;
        private Button butSeis;
        private Button butSete;
        private Button butOito;
        private Button butNove;
        private Button butVirgu;
        private Button butResult;
        private Button butDiv;
        private Button butMultpl;
        private Button butSoma;
        private Button butSubtr;
        private Button butApagar;
        private Label Calculadora;
        private Label label1;
    }
}
