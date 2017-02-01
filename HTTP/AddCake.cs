using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCake
{
    public class Cake
    {
        public string Name { get; set; }
        public decimal Price { get; set; }


    }
    class AddCake
    {
        static void Main()
        {
            Console.WriteLine("Content-type: text/html\r\n");
            string filecontent =
                File.ReadAllText(@"C:\xampp\htdocs\addcake.html");
            Console.WriteLine(filecontent);

            string postContent = Console.ReadLine();
            string[] variables = postContent.Split('&');
            string cakeName = variables[0].Split('=')[1];
            string cakePrice = variables[1].Split('=')[1];

            File.AppendAllText("database.csv",$"{cakeName},{cakePrice}" + Environment.NewLine);

        }
    }
}
