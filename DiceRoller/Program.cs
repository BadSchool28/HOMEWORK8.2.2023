using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{


    internal class Program
    {
        class Dice
        {
            private int mat;

            public Dice(int mat)
            {
                this.mat = mat;
            }

            public int xoay()
            {
                Random rand = new Random();
                return rand.Next(1, mat + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số mặt của xúc xắc: ");
            int mat = int.Parse(Console.ReadLine());

            Dice dice = new Dice(mat);

            Console.WriteLine("Xúc xắc có mặt: " + dice.xoay());
            Console.ReadLine();
        }
    }
}