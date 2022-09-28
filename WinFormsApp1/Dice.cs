using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Dice 
    {
        public int Luku1, Luku2;
        public int Value;
       
        public void Roll()
        {
            Random rng = new Random();
            Luku1 = rng.Next(1,6);
            Luku2 = rng.Next(1, 6);
        }
    }
}
