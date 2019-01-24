using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth_Year { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }



        public static string[] ReadFile(string filePath)
        {

            string setRoot = Environment.CurrentDirectory;
            string finalPath = Path.GetFullPath(Path.Combine(setRoot, filePath));
            string[] rawData = File.ReadAllLines(filePath);

            return rawData;
        }
    }
}