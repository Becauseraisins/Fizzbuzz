using System;

namespace fuzzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {   Random rand = new Random();
            int randomNumber = rand.Next(100);
            bool fuzz = randomNumber % 3 ==0;
            bool buzz = randomNumber % 5 ==0;
        //i had no idea how to seperate writing out the number from writing fuzz and buzz so i just put them in a completely seperate path
        if(fuzz||buzz){
            if(fuzz){
                Console.Write("fuzz");
            }
            if(buzz){
                Console.Write("buzz");
            }
        }
        else{
            Console.WriteLine(randomNumber);
        }

        }
    }
}
