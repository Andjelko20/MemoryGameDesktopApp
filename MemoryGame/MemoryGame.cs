using System.Windows.Forms;
using System.Data.OleDb;
using System;
using System.Media;
using System.Data.SqlClient;

namespace MemoryGame
{
    class MemoryGame
    {
		SqlConnection conn = Conn.conn;

		SoundPlayer player = new SoundPlayer("error_sound.wav");

        bool flag = false;
        int time = -1;
		
        internal MemoryGame()
        {

        }

        void updateDB(int tries, int time, string name, int size)
        {
                try
                {
                    conn.Open();
                    SqlCommand command1 = new SqlCommand("UPDATE Users SET Tries=@tries,TimeInSec=@time WHERE Username=@name and Size=@size;", conn);
                    command1.Parameters.AddWithValue("@tries", tries);
                    command1.Parameters.AddWithValue("@time", time);
                    command1.Parameters.AddWithValue("@name", name);
                    command1.Parameters.AddWithValue("@size", size);

                    command1.Connection = conn;
                    command1.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    player.Play();
                    MessageBox.Show("Problem sa bazom!");
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            
        }

        void readFromDb(string name, int size)
        {
            try
            {
                conn.Open();
				
                SqlCommand command = new SqlCommand("SELECT TimeInSec FROM Users WHERE Username=@user and Size=@size;", conn);
                command.Parameters.AddWithValue("@user", name);
                command.Parameters.AddWithValue("@size", size);
				
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    flag = true;

                    while (reader.Read())
                    {
                        this.time = reader.GetInt16(0);
                    }

                    reader.Close();
                }
            }

            catch (Exception e)
            
            {
                player.Play();
				
                MessageBox.Show("Problem sa bazom!");
                MessageBox.Show(e.Message);
            }

            finally
            
            {
                conn.Close();
            }
        }
		
        void addToDB(string name, int tries, int time, int size)
        {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
				
                    cmd.CommandText = @"INSERT INTO Users (Username,Tries,TimeInSec,Size) VALUES (@userName,@tries,@time,@size)";
				
                    cmd.Parameters.AddWithValue("@userName", name);
                    cmd.Parameters.AddWithValue("@tries", tries);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@size", size);

                    cmd.Connection = conn;

                    int i = cmd.ExecuteNonQuery();

                    if (i != 1)
                    {
                        MessageBox.Show("Baza nije užurirana!");
                    }
                }
                catch (Exception ex)
                {
                    player.Play();

                    MessageBox.Show("Postoji problem sa konekcijom!");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            
        }

        internal void databaseOperations(string name, int tries, int time, int size)
        {
            readFromDb(name, size); 

            if (flag == true)
            {
                if (this.time >= time)
                {
                    updateDB(tries, time, name, size);
                }
            }
            else
            {
                addToDB(name, tries, time, size);
            }

            flag = false;
            this.time = -1;
        }
    }
}
