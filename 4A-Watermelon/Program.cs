using System;

namespace _4A_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int melonWeight = Convert.ToInt16(Console.ReadLine());

            if(melonWeight >= 1 && melonWeight <= 100 && melonWeight % 2 == 0 && melonWeight == 2){
                Console.WriteLine("True");
            }else{
            Console.WriteLine("False");
            }   

            Console.ReadKey();
        }
    }
}
