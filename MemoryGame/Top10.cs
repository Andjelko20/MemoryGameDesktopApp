using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Top10 : Form
    {
        SqlConnection conn;

        public Top10()
        {
            InitializeComponent();
            size18radioButton.Checked= true;
        }

        internal void find10(int size)
        {
            try
            {
				conn = Conn.conn;
                conn.Open();

               
                SqlCommand cmd = new SqlCommand("SELECT TOP 10 Username,Tries,TimeInSec,Size FROM Users WHERE Size=@size ORDER BY TimeInSec,Tries;", conn);
                cmd.Parameters.AddWithValue("@size", size);

                SqlDataReader reader = cmd.ExecuteReader();

                StringBuilder sb = new StringBuilder(); 

                if (reader.HasRows) 
                {
                    int counter = 1;
                    while (reader.Read()) 
                    {
                        sb.Append(counter.ToString());
                        sb.Append(". ");
                        sb.Append("Ime: ");
                        sb.Append(reader.GetString(0).Trim());
                        sb.Append(" , ");
                        sb.Append("Vreme: ");
                        sb.Append(reader.GetInt32(2).ToString());
                        sb.Append(" , ");
                        sb.Append("Pokušaja: ");
                        sb.Append(reader.GetInt32(1).ToString());
                        sb.Append(" , ");
                        sb.Append("Veličina: ");
                        sb.Append(reader.GetInt32(3).ToString());
                        sb.Append(Environment.NewLine);

                        counter++;
                    }

                    textBox1.Text = sb.ToString(); 
                }
                else
                {
                    textBox1.Text = "";
                }
            }

            catch (Exception ex)
            
            {
                MessageBox.Show("Problem sa bazom!");
                MessageBox.Show(ex.Message);
            }

            finally
            
            {
                conn.Close(); 
            }
        }

        private void size18radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(size18radioButton.Checked)
            {
                find10(18);
            }
        }

        private void size24radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (size24radioButton.Checked)
            {
                find10(24);
            }
        }
    }
}
