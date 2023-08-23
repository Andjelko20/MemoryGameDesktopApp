using System;

namespace MemoryGame
{
    class Pictures
    {
        Random random; 

        public Pictures()
        {
            random = new Random();
        }
        internal string[] shuffleArray(string[] items, int arraySize)
        {
            int number;
            string temp;

            for (int y = 0; y < arraySize; y++)
            {
                number = random.Next(arraySize - 1);
                temp = items[y];
                items[y] = items[number];
                items[number] = temp;
            }

            return items;
        }
    }
}
