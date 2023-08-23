using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Media;

namespace MemoryGame
{
    public partial class Login : Form
    {
     
        Regex letters_numbers;
       
        SoundPlayer player;

        public Login()
        {
            InitializeComponent();
			
            player = new SoundPlayer("error_sound.wav");
			
            letters_numbers = new Regex(@"^[a-zA-Z0-9]+$");
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            if (letters_numbers.IsMatch(textBox1.Text))
            {
                GameArea gameArea = new GameArea(textBox1.Text);
                this.Hide();
                gameArea.ShowDialog();
                this.Close();
            }

            else 

            {
                player.Play();

                MessageBox.Show("Unesite validno korisničko ime!");
				
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
