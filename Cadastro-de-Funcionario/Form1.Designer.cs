namespace Cadastro_de_Funcionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_funcao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_resultadosalario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_resultadoIRPF = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_matricula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_avisofuncao = new System.Windows.Forms.Label();
            this.tx_avisosalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // box_funcao
            // 
            this.box_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_funcao.FormattingEnabled = true;
            this.box_funcao.Items.AddRange(new object[] {
            "Médico",
            "TI",
            "ADM"});
            this.box_funcao.Location = new System.Drawing.Point(51, 198);
            this.box_funcao.Name = "box_funcao";
            this.box_funcao.Size = new System.Drawing.Size(168, 39);
            this.box_funcao.TabIndex = 3;
            this.box_funcao.Text = "Função";
            this.box_funcao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salario total:";
            // 
            // tx_resultadosalario
            // 
            this.tx_resultadosalario.AutoSize = true;
            this.tx_resultadosalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resultadosalario.Location = new System.Drawing.Point(216, 277);
            this.tx_resultadosalario.Name = "tx_resultadosalario";
            this.tx_resultadosalario.Size = new System.Drawing.Size(143, 32);
            this.tx_resultadosalario.TabIndex = 6;
            this.tx_resultadosalario.Text = "Resultado";
            this.tx_resultadosalario.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "IRPF:";
            // 
            // tx_resultadoIRPF
            // 
            this.tx_resultadoIRPF.AutoSize = true;
            this.tx_resultadoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resultadoIRPF.Location = new System.Drawing.Point(513, 277);
            this.tx_resultadoIRPF.Name = "tx_resultadoIRPF";
            this.tx_resultadoIRPF.Size = new System.Drawing.Size(143, 32);
            this.tx_resultadoIRPF.TabIndex = 8;
            this.tx_resultadoIRPF.Text = "Resultado";
            this.tx_resultadoIRPF.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(488, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 72);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_cpf
            // 
            this.tx_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(462, 72);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(194, 38);
            this.tx_cpf.TabIndex = 11;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tx_matricula
            // 
            this.tx_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_matricula.Location = new System.Drawing.Point(183, 72);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(189, 38);
            this.tx_matricula.TabIndex = 12;
            this.tx_matricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "CPF:";
            // 
            // tx_nome
            // 
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(183, 135);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(473, 38);
            this.tx_nome.TabIndex = 14;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tx_salario
            // 
            this.tx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(467, 199);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(189, 38);
            this.tx_salario.TabIndex = 15;
            this.tx_salario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tx_avisofuncao
            // 
            this.tx_avisofuncao.AutoSize = true;
            this.tx_avisofuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tx_avisofuncao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tx_avisofuncao.Location = new System.Drawing.Point(48, 240);
            this.tx_avisofuncao.Name = "tx_avisofuncao";
            this.tx_avisofuncao.Size = new System.Drawing.Size(42, 17);
            this.tx_avisofuncao.TabIndex = 16;
            this.tx_avisofuncao.Text = "Aviso";
            // 
            // tx_avisosalario
            // 
            this.tx_avisosalario.AutoSize = true;
            this.tx_avisosalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tx_avisosalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tx_avisosalario.Location = new System.Drawing.Point(464, 240);
            this.tx_avisosalario.Name = "tx_avisosalario";
            this.tx_avisosalario.Size = new System.Drawing.Size(42, 17);
            this.tx_avisosalario.TabIndex = 17;
            this.tx_avisosalario.Text = "Aviso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.tx_avisosalario);
            this.Controls.Add(this.tx_avisofuncao);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tx_matricula);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_resultadoIRPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_resultadosalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_funcao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_funcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tx_resultadosalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tx_resultadoIRPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.TextBox tx_matricula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.Label tx_avisofuncao;
        private System.Windows.Forms.Label tx_avisosalario;
    }
}

