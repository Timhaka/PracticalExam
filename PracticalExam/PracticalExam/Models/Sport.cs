using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam.Models
{
    class Sport
    {
        public string Name { get; set; }
        public bool IsSummerSport { get; set; }
        public int YearCreated { get; set; }
        public string Description { get; set; }
        public int CountriesParticipating { get; set; }

        const int defaultYearCreated = 2015;
        enum SportTypes
        {
            Pysical,
            Mental,
            Water
        }

        public Sport()
        {
            YearCreated = defaultYearCreated;
        }

        public Sport(string name, bool isSommerSport, int yearCreated)
        {
            Name = name;
            IsSummerSport = isSommerSport;
            YearCreated = yearCreated;
            
        }
        public Sport(string name, bool isSommerSport, string description)
        {
            Name = name;
            IsSummerSport = isSommerSport;
            Description = description;

        }

        public virtual string GetInfo()
        {
            string info = "";

            info += Name + "\n";
            info += Description + "\n";
            info += SportTypes.Mental + "\n";
            
            return info;
        }

        public static string MyStaticMethod()
        {
            return "Hello World";
        }

    }
}
