namespace GeradorScriptExcel
{
    partial class Gerador
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
            txtUrlExcel = new TextBox();
            btnAbrirExcel = new Button();
            label1 = new Label();
            txtEscopo = new RichTextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            linhaInicial = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            linhaFinal = new NumericUpDown();
            groupBox1 = new GroupBox();
            cbSeparador = new ComboBox();
            label8 = new Label();
            btnGerar = new Button();
            ((System.ComponentModel.ISupportInitialize)linhaInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linhaFinal).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUrlExcel
            // 
            txtUrlExcel.BackColor = SystemColors.Control;
            txtUrlExcel.Location = new Point(12, 28);
            txtUrlExcel.Name = "txtUrlExcel";
            txtUrlExcel.ReadOnly = true;
            txtUrlExcel.Size = new Size(399, 23);
            txtUrlExcel.TabIndex = 0;
            txtUrlExcel.DoubleClick += btnAbrirExcel_Click;
            // 
            // btnAbrirExcel
            // 
            btnAbrirExcel.Location = new Point(417, 28);
            btnAbrirExcel.Name = "btnAbrirExcel";
            btnAbrirExcel.Size = new Size(75, 23);
            btnAbrirExcel.TabIndex = 1;
            btnAbrirExcel.Text = "Abrir ->";
            btnAbrirExcel.UseVisualStyleBackColor = true;
            btnAbrirExcel.Click += btnAbrirExcel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Arquivo Excel";
            // 
            // txtEscopo
            // 
            txtEscopo.Location = new Point(12, 85);
            txtEscopo.Name = "txtEscopo";
            txtEscopo.Size = new Size(478, 81);
            txtEscopo.TabIndex = 3;
            txtEscopo.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 4;
            label2.Text = "Escreva o escopo do script";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 169);
            label4.Name = "label4";
            label4.Size = new Size(247, 15);
            label4.TabIndex = 7;
            label4.Text = "insert into produto ([codigo], [nome], [valor])";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 169);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 8;
            label5.Text = "values ([A], '[B]', [C])";
            // 
            // linhaInicial
            // 
            linhaInicial.Location = new Point(96, 20);
            linhaInicial.Name = "linhaInicial";
            linhaInicial.Size = new Size(63, 23);
            linhaInicial.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 23);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 10;
            label6.Text = "Linha inicial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 23);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 12;
            label7.Text = "Linha final";
            // 
            // linhaFinal
            // 
            linhaFinal.Location = new Point(233, 20);
            linhaFinal.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            linhaFinal.Name = "linhaFinal";
            linhaFinal.Size = new Size(63, 23);
            linhaFinal.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linhaFinal);
            groupBox1.Controls.Add(cbSeparador);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(linhaInicial);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(15, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 53);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Valores";
            // 
            // cbSeparador
            // 
            cbSeparador.FormattingEnabled = true;
            cbSeparador.Items.AddRange(new object[] { "GO", "#" });
            cbSeparador.Location = new Point(404, 20);
            cbSeparador.Name = "cbSeparador";
            cbSeparador.Size = new Size(65, 23);
            cbSeparador.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 23);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 14;
            label8.Text = "Separador";
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(201, 258);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(102, 37);
            btnGerar.TabIndex = 16;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // Gerador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(502, 301);
            Controls.Add(btnGerar);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtEscopo);
            Controls.Add(label1);
            Controls.Add(btnAbrirExcel);
            Controls.Add(txtUrlExcel);
            MaximizeBox = false;
            MaximumSize = new Size(518, 340);
            MinimizeBox = false;
            MinimumSize = new Size(518, 340);
            Name = "Gerador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de inserts";
            ((System.ComponentModel.ISupportInitialize)linhaInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)linhaFinal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrlExcel;
        private Button btnAbrirExcel;
        private Label label1;
        private RichTextBox txtEscopo;
        private Label label2;
        private Label label4;
        private Label label5;
        private NumericUpDown linhaInicial;
        private Label label6;
        private Label label7;
        private NumericUpDown linhaFinal;
        private GroupBox groupBox1;
        private Label label8;
        private ComboBox cbSeparador;
        private Button btnGerar;
    }
}
