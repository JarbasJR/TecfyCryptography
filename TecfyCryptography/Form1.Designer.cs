namespace TecfyCryptography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Login = new System.Windows.Forms.TextBox();
            this.button1CripLogin = new System.Windows.Forms.Button();
            this.label3LoginCript = new System.Windows.Forms.Label();
            this.textBox1ReturnLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2Senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3ReturnSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1RestDec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2DecText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRIPTOGRAFA LOGIN E SENHA PARA O TECFY2SE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o Login:";
            // 
            // textBox1Login
            // 
            this.textBox1Login.Location = new System.Drawing.Point(108, 53);
            this.textBox1Login.Name = "textBox1Login";
            this.textBox1Login.Size = new System.Drawing.Size(180, 20);
            this.textBox1Login.TabIndex = 2;
            // 
            // button1CripLogin
            // 
            this.button1CripLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1CripLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1CripLogin.Location = new System.Drawing.Point(364, 46);
            this.button1CripLogin.Name = "button1CripLogin";
            this.button1CripLogin.Size = new System.Drawing.Size(126, 27);
            this.button1CripLogin.TabIndex = 3;
            this.button1CripLogin.Text = "Criptografar Login";
            this.button1CripLogin.UseVisualStyleBackColor = false;
            this.button1CripLogin.Click += new System.EventHandler(this.button1CripLogin_Click);
            // 
            // label3LoginCript
            // 
            this.label3LoginCript.AutoSize = true;
            this.label3LoginCript.BackColor = System.Drawing.Color.White;
            this.label3LoginCript.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3LoginCript.Location = new System.Drawing.Point(15, 83);
            this.label3LoginCript.Name = "label3LoginCript";
            this.label3LoginCript.Size = new System.Drawing.Size(120, 12);
            this.label3LoginCript.TabIndex = 4;
            this.label3LoginCript.Text = "Login Criptografado:";
            this.label3LoginCript.Click += new System.EventHandler(this.label3LoginCript_Click);
            // 
            // textBox1ReturnLogin
            // 
            this.textBox1ReturnLogin.Location = new System.Drawing.Point(141, 79);
            this.textBox1ReturnLogin.Name = "textBox1ReturnLogin";
            this.textBox1ReturnLogin.Size = new System.Drawing.Size(349, 20);
            this.textBox1ReturnLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite a Senha:";
            // 
            // textBox2Senha
            // 
            this.textBox2Senha.Location = new System.Drawing.Point(108, 128);
            this.textBox2Senha.Name = "textBox2Senha";
            this.textBox2Senha.Size = new System.Drawing.Size(180, 20);
            this.textBox2Senha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha Criptografada:";
            // 
            // textBox3ReturnSenha
            // 
            this.textBox3ReturnSenha.Location = new System.Drawing.Point(141, 158);
            this.textBox3ReturnSenha.Name = "textBox3ReturnSenha";
            this.textBox3ReturnSenha.Size = new System.Drawing.Size(349, 20);
            this.textBox3ReturnSenha.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Criptografar Senha";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "_____________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "DECRIPTOGRAFA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(364, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Decriptografar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1RestDec
            // 
            this.textBox1RestDec.Location = new System.Drawing.Point(123, 264);
            this.textBox1RestDec.Name = "textBox1RestDec";
            this.textBox1RestDec.Size = new System.Drawing.Size(367, 20);
            this.textBox1RestDec.TabIndex = 16;
            this.textBox1RestDec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "DeCriptografado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2DecText
            // 
            this.textBox2DecText.Location = new System.Drawing.Point(108, 234);
            this.textBox2DecText.Name = "textBox2DecText";
            this.textBox2DecText.Size = new System.Drawing.Size(180, 20);
            this.textBox2DecText.TabIndex = 14;
            this.textBox2DecText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Digite o texto:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TecfyCryptography.Properties.Resources.fund1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1RestDec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2DecText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3ReturnSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1ReturnLogin);
            this.Controls.Add(this.label3LoginCript);
            this.Controls.Add(this.button1CripLogin);
            this.Controls.Add(this.textBox1Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tecfy Cryptography for Tecfy2SE (v1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Login;
        private System.Windows.Forms.Button button1CripLogin;
        private System.Windows.Forms.Label label3LoginCript;
        private System.Windows.Forms.TextBox textBox1ReturnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2Senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3ReturnSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1RestDec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2DecText;
        private System.Windows.Forms.Label label8;
    }
}

