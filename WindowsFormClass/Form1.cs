using System;
using System.Text;

namespace WindowsFormClass
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int minLength = int.Parse(txtMin.Text);
            int maxLength = int.Parse(txtMax.Text);
            string smallLetters = "qwertyuioplkjhgfdsazxcvbnm";
            string Alphabets = string.Concat(smallLetters.ToUpper(), smallLetters);
            string others = "@#$%&*+=!?";
            string numbers = "1234567890";
            Random rdm = new Random();
            StringBuilder password = new StringBuilder();
            int passwordLength = rdm.Next(minLength, maxLength + 1);

            if (radioAlphabet.Checked)
            {
                string passwordCharacters = string.Concat(Alphabets);
                while (passwordLength-- > 0)
                    password.Append(passwordCharacters[rdm.Next(passwordCharacters.Length)]);
                txtWord.Text = password.ToString();
            }
            else if(radioNumbers.Checked)
            {
                string passwordCharacters = string.Concat(numbers);
                while (passwordLength-- > 0)
                    password.Append(passwordCharacters[rdm.Next(passwordCharacters.Length)]);
                txtWord.Text = password.ToString();
            }
            else if (radioAlphaNum.Checked)
            {
                string passwordCharacters = string.Concat(Alphabets, numbers, others);
                while (passwordLength-- > 0)
                    password.Append(passwordCharacters[rdm.Next(passwordCharacters.Length)]);
                txtWord.Text = password.ToString();
            }
            else
            {
                string passwordCharacters = string.Concat(Alphabets, numbers, others);
                while (passwordLength-- > 0)
                    password.Append(passwordCharacters[rdm.Next(passwordCharacters.Length)]);
                txtWord.Text = password.ToString();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMax.Text = " ";
            txtMin.Text = " ";
            txtWord.Text = " ";
            radioAlphabet.Checked = false;
            radioNumbers.Checked = false;
            radioAlphaNum.Checked = false;
            
        }
    }
}
