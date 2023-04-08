
using System;

namespace Csharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("hello");
           bool samenums;
           int win; 
           int[] usernum =  new int[5];
           int[] lottery = new int[5];
           Random random = new Random();

           for(int i = 0; i < lottery.Length; i++)
           {
            lottery[i] = random.Next(0, 40);
           }
           
           samenums = SameNums(lottery);

           if(samenums == false)
           {
            while(samenums == false)
            {
              for(int i = 0; i < lottery.Length; i++)
              {
               lottery[i] = random.Next(0, 40);
              }
            }
           }
           Console.WriteLine(" ");

           for(int i = 0; i < lottery.Length; i++)
           {
            Console.WriteLine($"Enter number  {i + 1}");
            usernum[i] = Convert.ToInt32(Console.ReadLine());
            
            if(usernum[i] > 40)
            {
                while(usernum[i] > 40)
                {
                    Console.WriteLine("Enter number that 40 or under");
                    usernum[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            while (usernum[i] == 0)
            {
             Console.WriteLine("Enter a valid number");
             usernum[i] = Convert.ToInt32(Console.ReadLine());
            }

           }

            Console.WriteLine(" ");
           Console.Write("lottery numbers:");
           for(int i = 0; i < lottery.Length; i++)
           {
            Console.Write( "  " + lottery[i]);
           }
           Console.WriteLine(" ");
           Console.Write("your numbers:   ");
           for(int i = 0; i < lottery.Length; i++)
           {
            Console.Write( "  " + usernum[i]);
           }

           win = Cross(lottery, usernum);
           Console.WriteLine(" ");

           Console.WriteLine($"you got {win} numbers right");

           Console.WriteLine(" ");


           for(int i = 0; i < lottery.Length; i++)
           {
            if(win == 1)
            {
             Console.WriteLine("you won : " + win + "0000" + " " + "gel");
            }
           }
        }
        static int Cross(int[] Lottery, int[] Usernum )
        {
            int result = 0;
            for(int i = 0; i < Lottery.Length; i++)
            {
                for(int j = 0; j < Lottery.Length; j++)
                {
                    if(Usernum[i] == Lottery[j])
                    {
                        result+=1;
                    }
                }
            }
            return result;
        }
        static bool SameNums(int[] L)
        {
            bool result;
            if (L[0] == L[1] || L[0] == L[2] || L[0] == L[3] || L[0] == L[4])
            {
             result = false;
            }
              if (L[1] == L[0] || L[1] == L[2] || L[1] == L[3] || L[1] == L[4])
            {
             result = false;
            }
              if (L[2] == L[1] || L[2] == L[0] || L[2] == L[3] || L[2] == L[4])
            {
             result = false;
            }
              if (L[3] == L[1] || L[3] == L[2] || L[3] == L[0] || L[3] == L[4])
            {
             result = false;
            }
              if (L[4] == L[1] || L[4] == L[2] || L[4] == L[3] || L[4] == L[0])
            {
             result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
    }
}

