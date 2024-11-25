
using System;


class Program
{
    static void Main()
    {
       Console.Write("masukan nilai alas segitiga: ");
       double alas = Convert.ToDouble(Console.ReadLine());


       Console.Write("masukan nilai tinggi segitiga: ");
       double tinggi = Convert.ToDouble(Console.ReadLine());


       double luas = alas * tinggi;

       Console.WriteLine("luas segitiga adalah: " + luas);
    }
}
