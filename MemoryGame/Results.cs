using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Results : Form
    {
        public Results(string name, string tries, string time)
        {
            InitializeComponent();

            textBox1.Text = name;
            textBox3.Text = tries;
            textBox4.Text = time;
        }
    }
}
