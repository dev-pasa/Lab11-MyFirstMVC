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


        /// <summary>
        /// Convert raw data to list when a data when string[] data is passed into the method  
        /// </summary>
        /// <param name="fullData"></param>
        /// <returns></returns>
        public static List<TimePerson> Search(int startYear, int endYear)
        {
            List<TimePerson> allPeople = new List<TimePerson>();
            string path = Path.Combine(AppContext.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string[] myFile = File.ReadAllLines(path);

            for (int i = 1; i < myFile.Length; i++)
            {
                string[] parsedCSV = myFile[i].Split(',');
                
                allPeople.Add(new TimePerson
                {
                    Year = Convert.ToInt32(parsedCSV[0]),
                    Honor = parsedCSV[1], 
                    Name = parsedCSV[2],
                    Country = parsedCSV[3], 
                    Birth_Year = (parsedCSV[4] == "") ? 0 : Convert.ToInt32(parsedCSV[4]),
                    DeathYear = (parsedCSV[5] == "") ? 0 : Convert.ToInt32(parsedCSV[5]),
                    Title = parsedCSV[6],
                    Category = parsedCSV[7], 
                    Context = parsedCSV[8],
                });
            }
            List<TimePerson> filter = allPeople.Where(p => (p.Year >= startYear) && (p.Year <= endYear)).ToList();
            return filter;
        }
    }
}