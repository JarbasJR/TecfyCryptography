using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecfyCryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1CripLogin_Click(object sender, EventArgs e)
        {
            if (textBox1Login.Text == "" || textBox1Login.Text == null)
            {
                MessageBox.Show("Login não digitado", ".:: Atenção ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string retorno = EncryptLogin(textBox1Login.Text);
                textBox1ReturnLogin.Text = retorno;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2Senha.Text == "" || textBox2Senha.Text == null)
            {
                MessageBox.Show("Senha não digitada", ".:: Atenção ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string retorno = EncryptLogin(textBox2Senha.Text);
                textBox3ReturnSenha.Text = retorno;
            }
        }

        public static string EncryptLogin(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void label3LoginCript_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2DecText.Text == "" || textBox2DecText.Text == null)
            {
                MessageBox.Show("TEXTO não digitado", ".:: Atenção ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string retorno = Decrypt(textBox2DecText.Text);
                textBox1RestDec.Text = retorno;
            }
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }





        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
