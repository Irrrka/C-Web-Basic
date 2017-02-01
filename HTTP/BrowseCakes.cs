using System;
using System.IO;
using System.Linq;

namespace BrowseCakes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Content-type: text/html\r\n");
            string filecontent =
                File.ReadAllText(@"C:\xampp\cgi-bin\browsecakes.html");
            Console.WriteLine(filecontent);

            string getContent = Environment.GetEnvironmentVariable("QUERY_STRING");
            string cakeName = getContent.Split('=')[1];
            string[] dbContent = File.ReadAllLines("database.csv");
            var filtered = dbContent.Where(s => s.Contains(cakeName));
            foreach (var f in filtered)
            {
                Console.WriteLine("<p>");
                string fName = f.Split(',')[0];
                string fPrice = f.Split(',')[1];
                Console.WriteLine(fName + " $" + fPrice);
                Console.WriteLine("</p>");
            }
