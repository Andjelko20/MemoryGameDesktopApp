using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class User
    {
        private string username;
        private int width;
        private int height;
        private int multiplier = 2;

        public User(string username)
        {
            this.username = username;
        }

        public string Username
        {
            get { return username; }
        }

        public void changeDimensions(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int getDimensions()
        {
            return width * height;
        }

        public int getDimensionsWithMultipler()
        {
            return width * height * multiplier;
        }
    }
}
