using System;

namespace lesson1.Solutions
{
    public class Lab3
    {
       public void Problem3_2()
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area->"+width*length);
        }
        public void Problem3_3()
        {
                    float val2;
        if (!float.TryParse(Console.ReadLine(), out val2))
        {
            Console.WriteLine("Not a valid float");
        }
        else {
            Console.WriteLine(Math.Round(val2));
        }
        }
        public void Problem3_4()
        {
            char ch;
            Char.TryParse(Console.ReadLine(), out ch);
            if (ch>=65 && ch<=90)
            {
                Console.WriteLine(char.ToLower(ch));
            }  
            else if (ch>=97 && ch<=122)
            {
                Console.WriteLine(char.ToUpper(ch));
            }        
        }
        public void Problem3_2_2()
        {
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            float c=float.Parse(a);
            float d = float.Parse(b);
            Console.WriteLine("Area->"+c*d);
        }
        public void Problem3_1()
        {
            string a = Console.ReadLine();
            int b=int.Parse(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(Convert.ToChar(b));
        }
    }
}