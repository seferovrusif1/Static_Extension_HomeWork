using Static__Extension.Checkers;
using Static__Extension.Models;
using System.Text.RegularExpressions;

namespace Static__Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write fulname");           string fulname = Console.ReadLine();
            while (!fulname.CheckFullnamee())
            {
                Console.WriteLine("Tam adi yeniden daxil edin:");
                fulname = Console.ReadLine();
            }




            Console.WriteLine("Write Group");             string group=Console.ReadLine();
            while (!group.CheckGroupNoo())
            {
                Console.WriteLine("Qrupu yeniden daxil edin:");
                group = Console.ReadLine();
            }
            


            Console.WriteLine("Write age");              int age=Convert.ToInt32(Console.ReadLine());



            Student telebe = new Student(fulname,group,age);
            Console.WriteLine(telebe);
        }
    }
        
}