using System;

namespace Bootcamp.Solutions
{
    public class Lab6
    {
        public void Problem6_23()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while(true)
            {
                int num2 = num / 10;
                num = num2;
                count++;
                if(num <= 0)
                {
                    System.Console.WriteLine(count);
                    break;
                }
            }
        }
        int degree(int num)
        {
            int m = 0;
            while(num != 0)
            {
                m++;
                num /= 10;
            }
            return m;
        }
        bool Arm(int x)
        {
            int num = degree(x);
            double sum = 0;
            int i = x;
            while(i != 0)
            {
                int temp = i % 10;
                sum += Math.Pow(temp, num);
                i /= 10;
            }
            if(sum == x)
            {
                return true;
            }
            return false;
        }
        public void Problem6_22()
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i <= num; i++)
            {
                if(Arm(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
        bool palindrom(int num)
        {
            int rev = 0, val;
            val = num;
            while(num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            if(val == rev)
                return true;
            else
                return false;
        }
        int reverseDigits(int num)
        {
            int rev_num = 0;
            while(num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num /= 10;
            }
            return rev_num;
        }
        public void Problem6_21()
        {
            int num = int.Parse(Console.ReadLine());
            int step = 0;
            while(palindrom(num) == false)
            {
                num += reverseDigits(num);
                step++;
            }
            Console.WriteLine($"{step} {num}");
            
        }
        int getNewNum(int num)
        {
            int sumOfDig = 0;
            int origNum = num;
            while(num != 0)
            {
                sumOfDig += num % 10;
                num /= 10;
            }
            int newNum = origNum % 10 * 10 + sumOfDig % 10;
            return newNum;
        }
        public void Problem6_20()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int newNum, numCpy = num; true; numCpy = newNum)
            {
                newNum = getNewNum(numCpy);
                count++;
                if(num == newNum)
                {
                    System.Console.WriteLine(count);
                    break;
                }
            }
        }       
    
      

        public void Problem6_17()
        {
            int num = int.Parse(Console.ReadLine());
            int x = 0, y = 0, yunalish = 0;
            while (num-- > 0)
            {
                int k = int.Parse(Console.ReadLine());
                switch (yunalish % 4)
                {
                    case 0: y += k; break;
                    case 1: x += k; break;
                    case 2: y -= k; break;
                    case 3: x -= k; break;
                    default: break;
                }
                yunalish++;
            }
            Console.WriteLine($"{x} {y}");

        }
    }
}
