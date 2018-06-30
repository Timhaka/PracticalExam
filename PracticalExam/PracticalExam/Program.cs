using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalExam.Models;

namespace PracticalExam
{
    class Program
    {


        static void Main(string[] args)
        {

            Sport fotball = new Sport("Fotball", true, 1919);
            Sport basketball = new Sport("Basketball", false, 1780);
            Sport tennis = new Sport("Tennis", true, 1670);
            Sport tableTennis = new Sport("TableTennis", false, 1810);
            Sport gymnastic = new Sport("Gymnastics", false, 1735);
            Sport hockey = new Sport("Hockey", false, 1688);
            Sport swiming = new Sport("Swiming", true, 1535);

            Sport[] arrayOfSport = new Sport[7];
            arrayOfSport[0] = fotball;
            arrayOfSport[1] = basketball;
            arrayOfSport[2] = tennis;
            arrayOfSport[3] = tableTennis;
            arrayOfSport[4] = gymnastic;
            arrayOfSport[5] = hockey;
            arrayOfSport[6] = swiming;

            List<Sport> listOfSport = new List<Sport>();
            listOfSport.Add(fotball);
            listOfSport.Add(basketball);
            listOfSport.Add(tennis);
            listOfSport.Add(tableTennis);
            listOfSport.Add(gymnastic);
            listOfSport.Add(hockey);
            listOfSport.Add(swiming);

            var summerSports = listOfSport.Where(s => s.IsSummerSport == true);

            foreach (var sport in summerSports)
            {
                Console.WriteLine(sport.Name);
            }

            var created1900 = listOfSport.Where(c => c.YearCreated > 1900);

            foreach (var year in created1900)
            {
                Console.WriteLine($"Sport created after 1900: {year.Name} Year: {year.YearCreated}");
            }

            foreach (var sportName in listOfSport)
            {
                Console.WriteLine($"Name of Sport: {sportName.Name}");
            }

            Console.WriteLine();

            for (int i = 6; i >= 0; i--)
            {
                Console.WriteLine("Backward Looping of list: "+ listOfSport[i].Name);
            }

            Console.WriteLine();
            
            fotball.Description = "11 Players on a field with a ball";

            Console.WriteLine(fotball.GetInfo());

            Console.WriteLine(Sport.MyStaticMethod());


            IceSport ice = new IceSport("Ice Hockey", "Play on ice with sticks", true, 100);

            Console.WriteLine(ice.GetInfo());
            
            Console.WriteLine(ice.Name);

        }
    }
}
