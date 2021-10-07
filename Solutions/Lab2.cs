
using System;

namespace lesson1.Solutions
{
    public class Lab2
    {
        public void Problem1()
        {
           Console.WriteLine(222222);
           Console.WriteLine(2+"    "+2);
           Console.WriteLine(2+"    "+2);
           Console.WriteLine(222222);
        }
        public void Problem2()
        {
           Console.WriteLine(" A");
           Console.WriteLine(" AA");
           Console.WriteLine("A A");
           Console.WriteLine("AAAA");
        }
        public void Problem3()
        {
           Console.WriteLine("Brithdate");

            Console.Write("Enter Month: ");
            string son = Console.ReadLine();

            int a = int.Parse(son);
            // string e = String.Format("{0:D2},a");
            Console.Write("Enter Date: ");
            string b = Console.ReadLine();

            int d = int.Parse(son);
           string e = a.ToString().PadLeft(2,'0');
           string k = b.ToString().PadLeft(2,'0');

            Console.WriteLine("Brithdate is" + " "  +  e  + '-' +  k);
        }
        public void Problem4()
        {
          
         Console.WriteLine("Sun"+" "+"Mon"+" "+"Tue"+" "+"Wed"+" "+"Thr"+" "+"Fri"+" "+"Sat");
         System.Console.WriteLine("    "+1+"    "+2+"   "+3+"   "+4+"   "+5+"   "+6);
         
           
        }
        public void Problem5()
        {
           string son = System.Console.ReadLine();
           int a = int.Parse(son);
           Console.WriteLine(a+""+a+""+a+""+a+""+a+""+a);
           Console.WriteLine(a+"    "+a);
           Console.WriteLine(a+"    "+a);
           Console.WriteLine(a+""+a+""+a+""+a+""+a+""+a);
        }
        public void Problem7()
        {
           string son = System.Console.ReadLine();
           int a = int.Parse(son);
           for (int i=1; i<=9; i++)
           {
               Console.WriteLine(a+"*"+i+"="+a*i);
           }
        }
        public void Problem8()
        {
            int i,fact=1,number;      
            Console.Write("Enter any Number: ");      
            number= int.Parse(Console.ReadLine());     
            for(i=1;i<=number;i++)
            {      
                fact=fact*i;      
            }      
            Console.WriteLine("Factorial of " +number+" is: "+fact);
        }
        
        public void Problem9()
        {
          
          int a1=0,a2=1,son=a1+a2;
        
          System.Console.WriteLine(a2);

          System.Console.WriteLine(son); 
  
          a1=a2;
          a2=son;
         son=a1+a2;
         System.Console.WriteLine(son +" ");  

          a1=a2;
          a2=son;
          son=a1+a2;
          System.Console.WriteLine(son +" ");

          a1=a2;
          a2=son;
         son=a1+a2;
        System.Console.WriteLine(son +" ");

         a1=a2;
         a2=son;
         son=a1+a2;
        System.Console.WriteLine(son +" ");
  
         
        }
    }
}