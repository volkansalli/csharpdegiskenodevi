using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            
            string s="20";
            
            int i=20;
            
            string ys=s + i.ToString();
            Console.WriteLine(ys);
            
            int yi=i + Convert.ToInt32(s); 
            Console.WriteLine(yi);

            string dt2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt2);
            
            string dt1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dt1);
            

            dt1 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dt1);
        }
    }
}
