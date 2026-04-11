using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLibrary
{
    public class Class1
    {
        private const double TotalFare = 500; 

        public string CalculateConcession(string name, int age)
        {
            if (age <= 5)
            {
                return $"{name}: Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double concessionFare = TotalFare - (TotalFare/100)*30; 
                return $"{name}: Senior Citizen - Fare after concession is {concessionFare}";
            }
            else
            {
                return $"{name}: Ticket Booked - Fare is {TotalFare}";
            }
        }
    }
}
