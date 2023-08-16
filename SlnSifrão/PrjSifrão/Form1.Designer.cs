namespace PrjSifrão
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
            txtID = new TextBox();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtRendaMensal = new TextBox();
            btnCadastrar = new Button();
            lblId = new Label();
            lblNome = new Label();
            lblCPF = new Label();
            lblDataNascimento = new Label();
            lblRendaMensal = new Label();
            dtpDataNascimento = new DateTimePicker();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(38, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(119, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(233, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(119, 120);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(233, 23);
            txtCPF.TabIndex = 2;
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.Location = new Point(119, 178);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.Size = new Size(233, 23);
            txtRendaMensal.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(182, 221);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(122, 39);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 6;
            lblId.Text = "Id:";
            lblId.Click += lblId_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(70, 94);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            lblNome.Click += label2_Click;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(82, 128);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 8;
            lblCPF.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(12, 152);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(101, 15);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data Nascimento:";
            // 
            // lblRendaMensal
            // 
            lblRendaMensal.AutoSize = true;
            lblRendaMensal.Location = new Point(5, 181);
            lblRendaMensal.Name = "lblRendaMensal";
            lblRendaMensal.Size = new Size(108, 15);
            lblRendaMensal.TabIndex = 10;
            lblRendaMensal.Text = "Renda Mensal (R$):";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(119, 152);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(233, 23);
            dtpDataNascimento.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 306);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblRendaMensal);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(btnCadastrar);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtRendaMensal;
        private TextBox textBox5;
        private Button btnCadastrar;
        private Label lblId;
        private Label lblNome;
        private Label lblCPF;
        private Label lblDataNascimento;
        private Label lblRendaMensal;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpDataNascimento;
    }
}